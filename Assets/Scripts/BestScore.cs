using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{

	[SerializeField]
	private Text _bestScoreText;

	public void Start ()
	{
		_bestScoreText.text = GameManager.GetInstance ().coins.ToString ();
	}




	public void UpdateBestScore (int newBestScore)
	{
		_bestScoreText.text = newBestScore.ToString ();
	}
}

public class BestScore : MonoBehaviour {

    [SerializeField]
    private Text _bestScoreText;

    private void Start()
    {
        _bestScoreText.text = GameManager.GetInstance().GetBestScore().ToString();
    }

    public void UpdateBestScore(int newBestScore) {
        _bestScoreText.text = newBestScore.ToString();
    }
}
