using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

	private static AudioManager instance;

	private Dictionary<string, AudioClip> AllClips = new Dictionary<string, AudioClip> ();

	//ATTENTION ces deux arrays doivent avoir la même longueur!!!!! (et dans l'ordre aussi)
	public AudioClip[] AllSounds;

    public static AudioManager GetInstance()
    {
        return instance;
    }

	//Singleton
	void Awake ()
	{
		if (AudioManager.instance == null) {
			AudioManager.instance = this;
		} else {
			Destroy (gameObject);
		}
	}

	// Use this for initialization
	void Start ()
	{    
		//intégration des 2 listes dans le dictionnaire
		for (int i = 0; i < AllSounds.Length; i++) {
			AllClips.Add (AllSounds [i].name, AllSounds [i]);               
		}           
	}

	//méthode à lancer depuis le GameObject émetteur de son. Doit être équipé d'un AudioSource!
	public void PlaySoundAtPosition (string key, AudioSource AS, bool looping)
	{
		if (AS != null) {
			AudioClip AC = null;

			if (AllClips.TryGetValue (key, out AC)) {          
				AS.loop = looping;
				AS.clip = AC;
				AS.Play ();               
			} 
		}
	}

	public void StopSound (GameObject go)
	{
		if (go.GetComponent<AudioSource> () != null) {
			AudioSource AS = go.GetComponent<AudioSource> ();
			AS.Stop ();
		}
	}

	//méthode pour jouer le son des collectible avec changement de pitch en fonction du niveau de combo
	public void PlayCollectibleSound (int combo, GameObject go)
	{
		if (go.GetComponent<AudioSource> () != null) {
			AudioSource AS = go.GetComponent<AudioSource> ();
			AudioClip AC = null;

			string key = "Coin";

			if (AllClips.TryGetValue (key, out AC)) {
				AS.pitch = 1;
				//AS.pitch = 1 + (0.2f * (combo - 1));
				AS.clip = AC;
				AS.loop = false;
				AS.Play ();
			}
		}
	}
}
