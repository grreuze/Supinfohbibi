using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class ScreenshotToThumbnail {

    // Takes a screenshot and makes a thumbnail
    //
    // Most of these calls MUST be made on the
    // main Unity thread, so they are in a Coroutine.
    // This function spreads the load out over multiple frames
    // to avoid FPS hitching.
    //
    // Memory
    // Allocates ~500KB for a 1/8 of 1920x1080 image
    // mainly for the resize. 
    // ~40KB for no resize, but conversion to JPG is slower.
    //
    // Params:
    // thumbWidth, thumbHeight : final size of thumbnail
    //  - Set thumbWidth to 0 for no resizing
    // throttleMS : maximum time (in milliseconds) to run
    //              before waiting a frame (when possible)
    //
    public IEnumerator CoScreenshotToThumbnail(int thumbWidth,
                                               int thumbHeight,
                                               int throttleMS) {
        int width = Screen.width;
        int height = Screen.height;

        // cached in Unity
        RenderTexture rt = RenderTexture.GetTemporary(width, height, 24);

        // Captures UI too
        // Render from all active cameras
        foreach (Camera cam in Camera.allCameras) {
            if (cam.enabled) {
                cam.targetTexture = rt;
                cam.Render();
                cam.targetTexture = null;
            }
        }

        RenderTexture.active = rt;

        // Take a rest, that probably took awhile
        yield return new WaitForEndOfFrame();

        // Now read that RenderTexture into a 2D buffer (calls the GPU?)
        Texture2D screenShot = new Texture2D(width, height, TextureFormat.RGB24, false);
        screenShot.wrapMode = TextureWrapMode.Clamp;

        // We use the high-resolution C# timer
        // to know when to wait a frame
        Stopwatch sw = new Stopwatch();
        sw.Start();

        //// Read in 4 chunks (1 pixel at a time was far too slow)
        //// NOTE : The 4 chunks are kinda arbitrary, might need tuning.
        int chunkWidth = width / 2;
        int chunkHeight = height / 2;
        for (int x = 0; x < width; x += chunkWidth) {
            for (int y = 0; y < height; y += chunkHeight) {
                screenShot.ReadPixels(new Rect(x, y, chunkWidth, chunkHeight), x, y);

                // If we've spent more than X ms, wait another frame
                if (sw.ElapsedMilliseconds > throttleMS) {
                    yield return new WaitForEndOfFrame();
                    sw.Reset();
                    sw.Start();
                }
            }
        }
        sw.Stop();

        // We are done with the RenderTexure
        // now that we read it into the Texture2D.
        RenderTexture.active = null;
        RenderTexture.ReleaseTemporary(rt);

        // Take another break
        yield return new WaitForEndOfFrame();

        ////////////
        // RESIZE WITH FILTERING
        ////////////
        // NOTE : I tried the TextureScaler from 
        // http://wiki.unity3d.com/index.php/TextureScale
        // but it allocates ~10MB and would take some work
        // to make into a Coroutine. Mainly the 10MB allocation
        // would certainly cause a GC hiccup later, 
        // so what's the point?

        // Resize the image but do it over time to avoid FPS spikes.
        // We still have to do this on the main
        // Unity thread because we are accessing Texture2D,
        // but we can do it in chunks.
        //
        // Code is based on Unity example :
        // https://docs.unity3d.com/ScriptReference/Texture2D.GetPixelBilinear.html
        //
        Texture2D destTex;
        if (thumbWidth > 0) {
            destTex = new Texture2D(thumbWidth, thumbHeight);

            // If we don't set to Clamp it will wrap the top and right 1 pixel border
            destTex.wrapMode = TextureWrapMode.Clamp;

            Color[] destPix = new Color[destTex.width * destTex.height];
            {
                Stopwatch swResize = new Stopwatch();
                swResize.Start();

                int y = 0;
                float xFrac = 0;
                float yFrac = 0;
                int x = 0;
                while (y < thumbHeight) {
                    x = 0;
                    while (x < thumbWidth) {
                        xFrac = x * 1.0F / (thumbWidth - 1);
                        yFrac = y * 1.0F / (thumbHeight - 1);
                        destPix[y * thumbWidth + x] = screenShot.GetPixelBilinear(xFrac, yFrac);
                        x++;
                    }

                    // Don't check EVERY pixel, that would be overkill
                    // and hurt performance.
                    //
                    // If we've spent more than X ms, wait another frame
                    if (swResize.ElapsedMilliseconds > throttleMS) {
                        yield return new WaitForEndOfFrame();
                        swResize.Reset();
                        swResize.Start();
                    }
                    y++;
                }
            }

            yield return new WaitForEndOfFrame();

            // <1 ms
            destTex.SetPixels(destPix);
            destTex.Apply();

            yield return new WaitForEndOfFrame();
        } else
            destTex = screenShot; // no resizing

        ////////////
        // CONVERT TO JPG
        ////////////
        // NOTE : I tried some C# encoders to run on 
        // another thread but they had bugs and weren't being maintained.
        // Since we've already resized the image it's fast
        // enough to use the Unity built-in one.

        // EncodeToPNG ~17 ms for 1920x1080
        // EncodeToJPG ~8 ms for 1920x1080
        // Takes <1 ms for a 1/8 1920x1080 image
        // Plus it doesn't allocate much memory (2.4KB)

        // 75 (default) looks terrible at this small size
        byte[] bytes = destTex.EncodeToJPG(90);
        //byte[] bytes = destTex.EncodeToPNG();

        yield return new WaitForEndOfFrame();

        // ** For testing ** 
        // This can be moved to a new thread but this is a ~5KB file now (using JPG)
        System.IO.File.WriteAllBytes(Application.persistentDataPath + "/SavedScreen.jpg", bytes);
    }
}﻿
