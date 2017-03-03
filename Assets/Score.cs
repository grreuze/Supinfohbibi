using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	int rankFinal;
	int pointsFinal;
	float timeFinal;

	GameObject time;
	GameObject points;
	GameObject rank;

	public Text timeDisplay;
	public Text pointsDisplay;
	public Text rankDisplay;
	public Text scoreDisplay;

	int scoreFinal;


	void Update ()
	{
		if (Input.GetKeyDown ("l")) {
			ScoreFinal ();
		}
	}

	public void ScoreFinal ()
	{
		time = GameObject.Find ("Time");
		timeFinal = time.GetComponent<Chronometer> ().time;

		points = GameObject.Find ("Points");
		pointsFinal = points.GetComponent<Points> ().points;

		rank = GameObject.FindGameObjectWithTag ("Player");
		rankFinal = rank.GetComponent<Ranking> ().GetRank ();

		scoreFinal = (int)((200 * (pointsFinal / timeFinal)) + Mathf.Abs ((((5 - rankFinal) * (pointsFinal - (2 * timeFinal))) / 2)));


		timeDisplay.text = "TIME: " + timeFinal;
		pointsDisplay.text = "POINTS: " + pointsFinal;
		rankDisplay.text = "RANK: " + rankFinal;
		scoreDisplay.text = "SCORE: " + scoreFinal;


	}
}
