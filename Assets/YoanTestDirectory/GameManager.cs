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
        Metrics.ins.Setup();

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
    public bool soundPause = false;

    public void SpawnFishes() {
        Instantiate(_fish, transform.position, transform.rotation);
        for (int i = 0; i < _nbOpponent; i++) {
            Vector3 spawnPosition = transform.position;
            spawnPosition.x += Random.Range(-2, 2);
            spawnPosition.z += Random.Range(-2, 2);

            GameObject go = Instantiate(aiFish, spawnPosition, transform.rotation);
            go.GetComponentInParent<AIFish>().movementSpeed = Random.Range(_minMoveSpeed, _maxMoveSpeed);
        }
        isPlaying = true;
        StartRun();
        Metrics.ins.StartRun();
    }

    public void EndRun() {
        if (trickSystem.isPlaying)
            trickSystem.EndOfTrick();

        CameraScript camera = Camera.main.GetComponent<CameraScript>();
        camera.SetNewState(camera.end);
        
        _endCanvas.enabled = true;
        _endCanvas.GetComponentInChildren<Score>().ScoreFinal();
    }

    public void StartRun()
    {
        _endCanvas.enabled = false;
    }
}
