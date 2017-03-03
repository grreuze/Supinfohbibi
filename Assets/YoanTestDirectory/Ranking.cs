using UnityEngine;
using UnityEngine.UI;

public class Ranking : MonoBehaviour {

    private FishController fish;
    private AIFish[] _opponentList;
    private int _rank = 0;
    Text display;

    private void Awake()
    {
        fish = GetComponent<FishController>();
        display = GameObject.Find("Rank").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update () {
        _opponentList = FindObjectsOfType<AIFish>();
        if (_opponentList.Length != 0)
        {
            _rank = 1;
            for (int i = 0; i < _opponentList.Length; i++)
            {
                if (_opponentList[i].GetAverageSpeed() > fish.GetAverageSpeed())
                {
                    _rank++;
                }
            }
            display.text = _rank.ToString(); ;
        }
    }

    public int GetRank()
    {
        return _rank;
    }
}
