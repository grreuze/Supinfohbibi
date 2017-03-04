using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class RestartScript : MonoBehaviour
{

	public GameObject buttonMenu;
	public GameObject buttonRestart;

	// Use this for initialization
	void Start ()
	{
		Canvas[] tmp = FindObjectsOfType<Canvas> ();
		foreach (Canvas canvas in tmp) {
			if (canvas.GetComponentInChildren<RestartScript> ()) {
				GameManager.instance._endCanvas = canvas;
			}
		}

		buttonMenu.transform.DOScale (new Vector3 (1.05f, 1.05f, 1.05f), 0.4f).SetLoops (-1, LoopType.Yoyo);
		buttonRestart.transform.DOScale (new Vector3 (1.05f, 1.05f, 1.05f), 0.4f).SetLoops (-1, LoopType.Yoyo);
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
