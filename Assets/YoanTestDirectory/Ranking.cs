using UnityEngine;
using UnityEngine.UI;

public class Ranking : MonoBehaviour {

    private float _totalTime;
    private float _middleSpeed;
    private FishController fish;
    private AIFish[] _opponentList;
    private float _nextRankSpeed;
    private float _previousRankSpeed;
    private int _rank;
    Text display;

    private void Awake()
    {
        fish = GetComponent<FishController>();
        display = GameObject.Find("Rank").GetComponent<Text>();
    }

    private void Start()
    {
        _totalTime = 0;
        _middleSpeed = 0;
        _rank = 0;
        _nextRankSpeed = 0;
        _previousRankSpeed = 0;
    }

    // Update is called once per frame
    void Update () {
        float time = Time.deltaTime;
        _middleSpeed = ((_middleSpeed * _totalTime) + (fish.movementSpeed * time)) / (_totalTime + time);
        _totalTime += time;
        if(_rank == 0){
            InitiateRank();
        }
        else if(_middleSpeed > _nextRankSpeed || _middleSpeed < _previousRankSpeed)
        {
            UpdateRank();
        }
	}

    private void UpdateRank() {
        _rank = 1;
        _nextRankSpeed = GameManager.GetInstance()._maxMoveSpeed;
        _previousRankSpeed = GameManager.GetInstance()._minMoveSpeed;
        for (int i = 0; i < GameManager.GetInstance()._nbOpponent; i++)
        {
            if (_opponentList[i].movementSpeed > _middleSpeed)
            {
                if (_opponentList[i].movementSpeed < _nextRankSpeed)
                {
                    _nextRankSpeed = _opponentList[i].movementSpeed;
                }
                _rank++;
            }
            else
            {
                if (_opponentList[i].movementSpeed > _previousRankSpeed)
                {
                    _previousRankSpeed = _opponentList[i].movementSpeed;
                }
            }
        }
        display.text = _rank.ToString(); ;
    }

    private void InitiateRank()
    {
        _opponentList = FindObjectsOfType<AIFish>();
        if (_opponentList.Length != 0)
        {
            UpdateRank();
        }
    }

    public int GetRank()
    {
        return _rank;
    }
}
