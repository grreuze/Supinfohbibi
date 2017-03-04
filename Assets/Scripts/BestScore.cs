using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour {

    public Text bestScore;

    private void Start()
    {
        GameManager.instance.UpdateBestScore();
    }

    // Update is called once per frame
    public void UpdateBestScore (int newBest) {
        bestScore.text = newBest.ToString();
	}
}
