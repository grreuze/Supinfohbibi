using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    private void Awake() {
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
        }
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public static GameManager GetInstance() {
        return instance;
    }

    public bool isPlaying = false;
    public float _playerStartMoveSpeed;
    public float _maxMoveSpeed;
    public float _minMoveSpeed;
    public int _nbOpponent;
    public float _maxOpponentSpeed;
    public GameObject _fish;
    public GameObject aiFish;
    public Canvas _endCanvas;

    public void SpawnFishes() {
        Instantiate(_fish, transform.position, transform.rotation);
        for (int i = 0; i < _nbOpponent; i++) {
            GameObject go = Instantiate(aiFish, transform.position, transform.rotation);
            //go.GetComponentInParent<AIFish>().SetSpeed(_minMoveSpeed + ((_maxOpponentSpeed - _minMoveSpeed) / _nbOpponent) * i);
        }
        isPlaying = true;
        StartRun();
    }

    public void EndRun()
    {
        _endCanvas.enabled = true;
    }

    public void StartRun()
    {
        _endCanvas.enabled = false;
    }
}
