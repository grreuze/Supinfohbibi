using UnityEngine;
using UnityEngine.UI;

public class Ranking : MonoBehaviour
{

	private FishController fish;
	private AIFish[] _opponentList;
	private int _rank = 0;
	private int lastRank = 0;
	GameObject display;

	public Color lastColor;
	public Color firstColor;

	private void Awake () {
		fish = GetComponent<FishController> ();
		display = GameObject.Find ("Rank");
	}

	// Update is called once per frame
	void Update ()
	{
		_opponentList = FindObjectsOfType<AIFish> ();
		if (_opponentList.Length != 0) {
			_rank = 1;
			for (int i = 0; i < _opponentList.Length; i++) {
				if (_opponentList [i].GetAverageSpeed () > fish.GetAverageSpeed ()) {
					_rank++;
				}
			}

		}

		if (_rank != lastRank) {
			display.GetComponent<Text> ().text = _rank.ToString ();
			display.GetComponent<Text> ().color = Color.Lerp (firstColor, lastColor, (float)(((float)_rank - 1f) / ((float)GameManager.GetInstance ()._nbOpponent + 1f)));
			print ((_rank - 1) / (GameManager.GetInstance ()._nbOpponent + 1));
			print (_rank);
			display.GetComponent<Animation> ().Play ("RankAnim");
			lastRank = _rank;

		}



	}




	public int GetRank ()
	{
		return _rank;
	}
}
