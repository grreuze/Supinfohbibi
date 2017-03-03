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
		gm = GameManager.instance;
		HUD.enabled = false;
	}

	public void Go ()
	{
		gm.SpawnFishes ();
		titleScreen.enabled = false;
		HUD.enabled = true;
		HUD.GetComponentInChildren<Chronometer> ().LaunchTimer ();        
		Destroy (this);
	}
}
