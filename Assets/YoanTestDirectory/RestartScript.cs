using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		Canvas[] tmp = FindObjectsOfType<Canvas> ();
		foreach (Canvas canvas in tmp) {
			if (canvas.GetComponentInChildren<RestartScript> ()) {
				GameManager.instance._endCanvas = canvas;
			}
		}
	}

	// Update is called once per frame
	void Update ()
	{
		
	}

	public void ReloadScene ()
	{
		AudioManager.ins.PlaySoundAtPosition ("SmallPok", gameObject, false);
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
