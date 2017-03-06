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


		timeDisplay.text = "" + timeFinal;
		pointsDisplay.text = "" + pointsFinal;
		rankDisplay.text = "" + rankFinal;
		scoreDisplay.text = "" + scoreFinal;

        if(GameManager.instance.IsScoreBetterThanBest(scoreFinal))
        {
            Debug.Log("BestScore");
        }

		//StartCoroutine ("RollingScore");

	}

    public float GetFinalTime()
    {
        return timeFinal;
    }

	/*	IEnumerator  RollingScore ()
	{
		int i = 0;
		Debug.Log (0.01f * (1 / Mathf.Floor (Mathf.Log10 (scoreFinal) + 1)));
		while (i < scoreFinal) {
			i++;
			yield return new WaitForSeconds (0.0001f * (1 / Mathf.Floor (Mathf.Log10 (scoreFinal) + 1)));
			scoreDisplay.text = "SCORE: " + i;
		}
	
	}*/
}
