using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(FishMoving))]
public class Ranking : MonoBehaviour {

    private float _totalTime;
    private float _middleSpeed;
    private FishMoving _fishMove;
    private Opponent[] _opponentList;
    private float _nextRankSpeed;
    private float _previousRankSpeed;
    private int _rank;

    private void Awake()
    {
        _fishMove = GetComponentInParent<FishMoving>();
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
        _middleSpeed = ((_middleSpeed * _totalTime) + (_fishMove.GetMovementSpeed() * time)) / (_totalTime + time);
        _totalTime += time;
        if(_rank == 0){
            InitiateRank();
        }
        else if(_middleSpeed > _nextRankSpeed || _middleSpeed < _previousRankSpeed)
        {
            UpdateRank();
        }
        Debug.Log(GetRank());
	}

    private void UpdateRank() {
        _rank = 1;
        _nextRankSpeed = GameManager.GetInstance()._maxMoveSpeed;
        _previousRankSpeed = GameManager.GetInstance()._minMoveSpeed;
        for (int i = 0; i < GameManager.GetInstance()._nbOpponent; i++)
        {
            if (_opponentList[i].GetSpeed() > _middleSpeed)
            {
                if (_opponentList[i].GetSpeed() < _nextRankSpeed)
                {
                    _nextRankSpeed = _opponentList[i].GetSpeed();
                }
                _rank++;
            }
            else
            {
                if (_opponentList[i].GetSpeed() > _previousRankSpeed)
                {
                    _previousRankSpeed = _opponentList[i].GetSpeed();
                }
            }
        }

    }

    private void InitiateRank()
    {
        _opponentList = FindObjectsOfType<Opponent>();
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
