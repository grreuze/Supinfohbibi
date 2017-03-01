using UnityEngine;
using System.Collections;

public class MuteAudio : MonoBehaviour
{
	public GameObject SpriteOn;
	public GameObject SpriteOff;


	void Start ()
	{
		AudioListener.pause = false;
	}

	public void OnClicked ()
	{

		AudioListener.pause = !AudioListener.pause;
	}

	void Update ()
	{

		if (AudioListener.pause == false) {
			SpriteOn.SetActive (true);
			SpriteOff.SetActive (false);
		}

		if (AudioListener.pause == true) {
			SpriteOn.SetActive (false);
			SpriteOff.SetActive (true);
		}

	}


}