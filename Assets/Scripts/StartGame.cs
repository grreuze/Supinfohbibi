using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{

	GameManager gm;

	[SerializeField]
	Canvas titleScreen, HUD;

	// Use this for initialization
	void Start ()
	{
		AudioManager.ins.PlaySoundAtPosition ("Menu" + Random.Range (1, 5), GameObject.Find ("Music"), true);

		gm = GameManager.instance;
		HUD.enabled = false;
	}

	public void Go ()
	{

		AudioManager.ins.StopSound (GameObject.Find ("Music"));
		AudioManager.ins.PlaySoundAtPosition ("Race" + Random.Range (1, 5), GameObject.Find ("Music"), true);


		AudioManager.ins.PlaySoundAtPosition ("BigPok", gameObject, false);
		gm.SpawnFishes ();
		titleScreen.enabled = false;
		HUD.enabled = true;
		HUD.GetComponentInChildren<Chronometer> ().LaunchTimer ();        
		Destroy (this);
	}
}
