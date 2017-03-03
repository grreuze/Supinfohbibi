using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;
    [SerializeField]
    bool playAuto;

    private void Awake() {
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
        } else {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    void Start() {
        trickSystem = FindObjectOfType<Trick_Pattern>();
        if (playAuto)
            SpawnFishes();
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
    private Trick_Pattern trickSystem;

    public void SpawnFishes() {
        Instantiate(_fish, transform.position, transform.rotation);
        for (int i = 0; i < _nbOpponent; i++) {
            Vector3 spawnPosition = transform.position;
            spawnPosition.x += Random.Range(-2, 2);
            spawnPosition.z += Random.Range(-2, 2);

            GameObject go = Instantiate(aiFish, spawnPosition, transform.rotation);
            go.GetComponentInParent<AIFish>().movementSpeed = Random.Range(_minMoveSpeed, _maxMoveSpeed);

            //go.GetComponentInParent<AIFish>().SetSpeed(_minMoveSpeed + ((_maxOpponentSpeed - _minMoveSpeed) / _nbOpponent) * i);
        }
        isPlaying = true;
        StartRun();
    }

    public void EndRun() {
        if (trickSystem.isPlaying)
            trickSystem.EndOfTrick();

        _endCanvas.enabled = true;
    }

    public void StartRun()
    {
        _endCanvas.enabled = false;
    }
}
