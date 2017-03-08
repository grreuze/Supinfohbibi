using UnityEngine;
using UnityEngine.UI;

public class Ranking : MonoBehaviour
{

	private FishController fish;
	private AIFish[] _opponentList;
	private int _rank = 0;
	private int lastRank = 0;
	private GameObject display;
    private Text displayText;
    private Animation displayAnim;
    private GameManager _gameManager;

	public Color lastColor;
	public Color firstColor;

	private void Awake () {
		fish = GetComponent<FishController> ();
		display = GameObject.Find ("Rank");
        _gameManager = GameManager.GetInstance();
        if(display)
        {
            displayText = display.GetComponent<Text>();
            displayAnim = display.GetComponent<Animation>();
        }
	}

	// Update is called once per frame
	void Update ()
	{
        if (_opponentList == null)
            _opponentList = FindObjectsOfType<AIFish>();
        else if (_opponentList.Length != 0)
        {
            _rank = 1;
            for (int i = 0; i < _opponentList.Length; i++)
            {
                if (_opponentList[i].GetAverageSpeed() > fish.GetAverageSpeed())
                {
                    _rank++;
                }
            }
        }
		if (_rank != lastRank) {
			displayText.text = _rank.ToString ();
			displayText.color = Color.Lerp (firstColor, lastColor, (_rank - 1f) / (_gameManager.opponents.Length + 1f));
			displayAnim.Play ("RankAnim");
			lastRank = _rank;
		}
	}
    
	public int GetRank ()
	{
		return _rank;
	}
}
