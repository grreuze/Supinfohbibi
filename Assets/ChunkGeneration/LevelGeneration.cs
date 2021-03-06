﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneration : MonoBehaviour {

    private static LevelGeneration ins;

    //SEED
    public string Seed;
    string[] choppedSeed;

    //chunks spéciaux
    public GameObject FinalChunkPrefab;

    //l'array de chunks
    public GameObject[] Chunks;

    [HideInInspector]
    public Transform CurrentEndPoint;

    [HideInInspector]
    public float currentLength;

    //INTS
    //nombre de chunks instanciés
    private int chunkScore;
    //le chunk précédemment instancié (pour éviter les doublons)
    private int previousChunkIndex;
    //l'int random pour pick le chunk a instancier
    private int chunkIndexer;
    //la longueur de la run
    public int runLength;

    //BOOLS
    //détermine si on peut instancier ou pas de nouveaux chunks
    private bool canGenerate = true;

    public static LevelGeneration GetInstance()
    {
        return ins;
    }

    //Singleton
    private void Awake() {
        if (LevelGeneration.ins == null) {
            LevelGeneration.ins = this;
        } else {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start() {

        GenerateSeed();
        ChopSeed();    

        StartCoroutine(GenerationCoroutine(choppedSeed));
    }

    public void Generate(int ind)
    {

        if (chunkScore == runLength -1 && canGenerate)
        {
            Instantiate(FinalChunkPrefab, CurrentEndPoint.position, Quaternion.Euler(CurrentEndPoint.eulerAngles.x, CurrentEndPoint.eulerAngles.y, CurrentEndPoint.eulerAngles.z));
            canGenerate = false;
        }
        else if (canGenerate)
        {
            
            //Instanciation du préfab
            Instantiate(Chunks[ind], CurrentEndPoint.position, Quaternion.Euler(CurrentEndPoint.eulerAngles.x, CurrentEndPoint.eulerAngles.y, CurrentEndPoint.eulerAngles.z));

            chunkScore++;
        }
    }

    //vérifie que le random est bien valide (avec exception au tout début)
    bool CheckChunkValidity(int ind) {
        if (chunkScore == 0)
            return false;

        if (ind != previousChunkIndex)
            return false;
        else return true;
    }

    private void ChopSeed()
    {
        choppedSeed = Seed.Split(" "[0]);
    }

    private void GenerateSeed()
    {
        Seed = string.Empty;

        for(int i = 0; i < runLength; i++)
        {
            do
            {
                chunkIndexer = Random.Range(0, Chunks.Length);
            } while (CheckChunkValidity(chunkIndexer));

            previousChunkIndex = chunkIndexer;
            chunkScore++;

            //append
            Seed += chunkIndexer.ToString() + " "; 
        }
    }

    public IEnumerator GenerationCoroutine(string[] CS)
    {
        chunkScore = 0;

        for (int i = 0; i < runLength; i++)
        {
            yield return new WaitForEndOfFrame();

            //générer chunk par chunk
            Generate(int.Parse(CS[i]));         
        }

        yield return null;
    }
}
