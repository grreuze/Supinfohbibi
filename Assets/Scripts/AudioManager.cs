using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public static AudioManager ins;

    private Dictionary<string, AudioClip> AllClips = new Dictionary<string, AudioClip>();

    //ATTENTION ces deux arrays doivent avoir la même longueur!!!!! (et dans l'ordre aussi)
    public AudioClip[] AllSounds;

    //Singleton
    void Awake()
    {
        if(AudioManager.ins == null)
        {
            AudioManager.ins = this;
        }
        else
        {
            Debug.Log("Second instance of AudioManager detected!!!! Destroying last instance.");
            Destroy(gameObject);
        }
    }

	// Use this for initialization
	void Start ()
    {    
            //intégration des 2 listes dans le dictionnaire
            for (int i = 0; i < AllSounds.Length; i++)
            {
                AllClips.Add(AllSounds[i].name, AllSounds[i]);               
            }           
	}

    //méthode à lancer depuis le GameObject émetteur de son. Doit être équipé d'un AudioSource!
    public void PlaySoundAtPosition(string key, GameObject go, bool looping)
    {
        if(go.GetComponent<AudioSource>() != null)
        {
            AudioSource AS = go.GetComponent<AudioSource>();
            AudioClip AC = null;

            if(AllClips.TryGetValue(key, out AC))
            {          
                    AS.loop = looping;
                    AS.clip = AC;
                    AS.Play();               
            }
            else
            {
                Debug.Log(go.name +": AudioManager Key not found!!!");
            }    
        }
        else
        {
            Debug.Log(go.name + " has no AudioSource!!! Please add one.");
        }
    }

    public void StopSound(GameObject go)
    {
        if(go.GetComponent<AudioSource>() != null)
        {
            AudioSource AS = go.GetComponent<AudioSource>();
            AS.Stop();
        }
        else
        {
            Debug.Log(go.name + " has no AudioSource!!! Please add one.");
        }
    }

    //méthode pour jouer le son des collectible avec changement de pitch en fonction du niveau de combo
    public void PlayCollectibleSound(int combo, GameObject go)
    {
        if(go.GetComponent<AudioSource>() != null)
        {
            AudioSource AS = go.GetComponent<AudioSource>();
            AudioClip AC = null;

            string key = "Collectible_Sound";

            if (AllClips.TryGetValue(key, out AC))
            {
                AS.pitch = 1 + (0.2f * combo);
                AS.clip = AC;
                AS.loop = false;
                AS.Play();
            }
        }
        else
        {
            Debug.Log(go.name + " has no AudioSource!!! Please add one.");
        }
    }
}
