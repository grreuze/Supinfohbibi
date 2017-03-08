using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour {

    [SerializeField]
    private Text _bestScoreText;

    private void Start()
    {
        _bestScoreText.text = GameManager.GetInstance().coins.ToString();
    }

    public void UpdateBestScore(int totalcoins) {
        _bestScoreText.text = totalcoins.ToString();
    }
}
