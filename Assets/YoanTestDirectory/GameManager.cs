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

    private BestScore[] bestScoreText;

    void Start() {
        Metrics.ins.Setup();

        trickSystem = FindObjectOfType<Trick_Pattern>();
        if (playAuto)
            SpawnFishes();
        UpdateBestScore();
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
    private int bestScore = 0;

    public void UpdateBestScore()
    {
        if(bestScoreText == null)
            bestScoreText = GameObject.FindObjectsOfType<BestScore>();
        foreach (BestScore best in bestScoreText)
        {
            best.UpdateBestScore(bestScore);
        }
    }

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

    public bool IsScoreBetterThanBest(int score)
    {
        if(score > bestScore)
        {
            bestScore = score;
            UpdateBestScore();
            return true;
        }
        else
        {
            return false;
        }
    }
}
