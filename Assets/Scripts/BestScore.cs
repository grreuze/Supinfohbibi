using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour {

    public Text bestScore;
	
	// Update is called once per frame
	public void UpdateBestScore (int newBest) {
        bestScore.text = "BEST SCORE : " + newBest;
	}
}
