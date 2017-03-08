using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	int rankFinal;
	//int pointsFinal;
	//float timeFinal;

	//GameObject time;
	//GameObject points;

	Text HUDrank;
	//public Text timeDisplay;
	//public Text pointsDisplay;
	public Text rankDisplay;
	public Text coinsDisplay;
	//public Text scoreDisplay;

	//int scoreFinal;

	/*void Update ()
	{
		if (Input.GetKeyDown ("l")) {
			ScoreFinal ();
		}
	}*/

	public void ScoreFinal ()
	{
		//time = GameObject.Find ("Time");
		//timeFinal = time.GetComponent<Chronometer> ().time;

		//points = GameObject.Find ("Points");
		//pointsFinal = points.GetComponent<Points> ().points;

		HUDrank = GameObject.Find ("Rank").GetComponent<Text> ();
		rankFinal = FindObjectOfType<Ranking> ().GetRank ();

		//scoreFinal = (int)((200 * (pointsFinal / timeFinal)) + Mathf.Abs ((((5 - rankFinal) * (pointsFinal - (2 * timeFinal))) / 2)));


		//timeDisplay.text = "" + timeFinal;
		//pointsDisplay.text = "" + pointsFinal;
		rankDisplay.text = "" + rankFinal;
		rankDisplay.color = HUDrank.color;

		coinsDisplay.text = "" + GameObject.Find ("Coins").GetComponent<CoinsCount> ().runCoins;

		GameManager.GetInstance ().UpdateBestScore ();

		//scoreDisplay.text = "" + scoreFinal;

		/*if (GameManager.instance.IsScoreBetterThanBest (scoreFinal)) {
			Debug.Log ("BestScore");
		}*/
			

	}

	/*public float GetFinalTime ()
	{
		return timeFinal;
	}*/
		
}
