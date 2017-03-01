using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private static GameManager _instance;

    private void Awake() {
        if (_instance != null && _instance != this) {
            Destroy(this.gameObject);
        }
        _instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public static GameManager GetInstance() {
        return _instance;
    }

    public float _playerStartMoveSpeed;
    public float _maxMoveSpeed;
    public float _minMoveSpeed;
    public int _nbOpponent;
    public float _maxOpponentSpeed;
}
