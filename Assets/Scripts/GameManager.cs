using UnityEngine;

public class GameManager : MonoBehaviour {

    private static GameManager instance;
    [SerializeField]
    private bool playAuto;
    private Metrics _metrics;

    private void Awake() {
        if (instance != null && instance != this) {
            Destroy(gameObject);
        } else {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }


    void Start() {
        _metrics = Metrics.GetInstance();
        Screen.orientation = ScreenOrientation.Portrait;
        endRun = GetComponent<EndRun>();
        _metrics.Setup();
        endRun.OnRunStart();
        trickSystem = FindObjectOfType<Trick_Pattern>();
        if (playAuto)
            SpawnFishes();
        _bestScore = endRun.PlayerStats.bestScore;
        UpdateBestScore();
    }

    public static GameManager GetInstance() {
        return instance;
    }

    public bool isPlaying = false;
    public float baseMoveSpeed;
    public float accelerateMoveSpeed;
    public float boostMoveSpeed;
    public bool deceleratingLerp_AccelerateToBase;
    public float timeToLosingAcceleration;
    public bool deceleratingLerp_BoostToAccelerate;
    public float timeToLosingBoost;
    //public float decelerateMoveSpeed;
    public float JumpForce;
    public float _playerStartMoveSpeed;
    public float _maxMoveSpeed;
    public float _minMoveSpeed;
    public int _nbOpponent;
    public float _maxOpponentSpeed;
    public GameObject _fish;
    public GameObject aiFish;
    public Canvas _endCanvas;
    public bool soundPause = false;
    public int coins;

    private Trick_Pattern trickSystem;
    private int _bestScore = 0;
    private EndRun endRun;

    public void UpdateBestScore() {
        foreach (BestScore best in FindObjectsOfType<BestScore>()) {
            best.UpdateBestScore(_bestScore);
        }
    }

    public void SpawnFishes() {
        Instantiate(_fish, transform.position, transform.rotation);
        for (int i = 0; i < _nbOpponent; i++) {
            Vector3 spawnPosition = transform.position;
            spawnPosition.x += Random.Range(-2, 2);
            spawnPosition.z += Random.Range(-2, 2);

            Instantiate(aiFish, spawnPosition, transform.rotation);
            //go.GetComponentInParent<AIFish>().movementSpeed = Random.Range(_minMoveSpeed, _maxMoveSpeed);
        }
        isPlaying = true;
        StartRun();
        _metrics.StartRun();
    }

    public void EndRun()
    {
        if(!trickSystem)
            trickSystem = FindObjectOfType<Trick_Pattern>();
        trickSystem.EndOfTrick(); 
        
        GameObject.Find("HUD").GetComponent<Canvas>().enabled = false;

        CameraScript camera = Camera.main.GetComponent<CameraScript>();
        camera.SetNewState(camera.end);
        
        _endCanvas.enabled = true;
        _endCanvas.GetComponentInChildren<Score>().ScoreFinal();
        endRun.LaunchEndRunProtocol();
    }

    public void StartRun()
    {
        _endCanvas.enabled = false;
    }

    public bool IsScoreBetterThanBest(int score)
    {
        if(score > _bestScore)
        {
            _bestScore = score;
            UpdateBestScore();
            return true;
        }
        else
        {
            return false;
        }
    }

    public int GetBestScore()
    {
        return _bestScore;
    }

    public void SetEndCanvas(Canvas newCanvas)
    {
        _endCanvas = newCanvas;
    }
}
