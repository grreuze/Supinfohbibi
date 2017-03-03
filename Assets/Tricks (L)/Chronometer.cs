using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chronometer : MonoBehaviour
{

	public float time = 0;

	string textTime;

	bool timerIsOn = false;

	public void LaunchTimer ()
	{
		time = 0;
		timerIsOn = true;
	}

	public void StopTimer ()
	{
		timerIsOn = false;
	}

	void Update ()
	{
		//DEBUG
		if (Input.GetKeyDown ("t")) {
			LaunchTimer ();
		}

		if (Input.GetKeyDown ("s")) {
			StopTimer ();
		}
		//DEBUG

		float minutes = (int)time / 60;
		float seconds = (int)time % 60;
		float fraction = (int)(time * 100) % 100;

		textTime = string.Format ("{0:00}:{1:00}:{2:00}", minutes, seconds, fraction); 


		if (timerIsOn == true) {
			time += Time.deltaTime;
			this.gameObject.GetComponent<Text> ().text = textTime;
		}


	}
}
