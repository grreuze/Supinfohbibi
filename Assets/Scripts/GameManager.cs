using UnityEngine;

public class GameManager : MonoBehaviour
{

	public static GameManager instance;
	[SerializeField]
	bool playAuto;

	private void Awake ()
	{
		if (instance != null && instance != this) {
			Destroy (gameObject);
		} else {
			instance = this;
			DontDestroyOnLoad (gameObject);
		}
	}

	private BestScore[] bestScoreText;

	void Start ()
	{
		Screen.orientation = ScreenOrientation.Portrait;
		endRun = GetComponent<EndRun> ();
		Metrics.ins.Setup ();
		endRun.OnRunStart ();
		trickSystem = FindObjectOfType<Trick_Pattern> ();
		if (playAuto)
			SpawnFishes ();
		bestScore = endRun.PlayerStats.bestScore;
		UpdateBestScore ();
	}

	public static GameManager GetInstance ()
	{
		return instance;
	}

	public bool isPlaying = false;
	public float baseMoveSpeed;
	public float accelerateMoveSpeed;
	public float decelerateMoveSpeed;
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
	private int bestScore = 0;
	private EndRun endRun;

	public void UpdateBestScore ()
	{
		bestScoreText = FindObjectsOfType<BestScore> ();
		foreach (BestScore best in bestScoreText) {
			best.UpdateBestScore (bestScore);
		}
	}

	public void SpawnFishes ()
	{
		Instantiate (_fish, transform.position, transform.rotation);
		for (int i = 0; i < _nbOpponent; i++) {
			Vector3 spawnPosition = transform.position;
			spawnPosition.x += Random.Range (-2, 2);
			spawnPosition.z += Random.Range (-2, 2);

			GameObject go = Instantiate (aiFish, spawnPosition, transform.rotation);
			//go.GetComponentInParent<AIFish>().movementSpeed = Random.Range(_minMoveSpeed, _maxMoveSpeed);
		}
		isPlaying = true;
		StartRun ();
		Metrics.ins.StartRun ();
	}

	public void EndRun ()
	{
		if (!trickSystem)
			trickSystem = FindObjectOfType<Trick_Pattern> ();
		trickSystem.EndOfTrick (); 
        
		GameObject.Find ("HUD").GetComponent<Canvas> ().enabled = false;

		/*AudioManager.ins.StopSound (GameObject.Find ("Music"));
		AudioManager.ins.PlaySoundAtPosition ("End", GameObject.Find ("Music"), true);*/

		AudioManager.ins.StopSound (GameObject.Find ("WaterSound"));
		AudioManager.ins.PlaySoundAtPosition ("LittleFlow", GameObject.Find ("WaterSound"), true);


		CameraScript camera = Camera.main.GetComponent<CameraScript> ();
		camera.SetNewState (camera.end);
        
		_endCanvas.enabled = true;
		_endCanvas.GetComponentInChildren<Score> ().ScoreFinal ();
		endRun.LaunchEndRunProtocol ();
	}

	public void StartRun ()
	{
		_endCanvas.enabled = false;
	}

	public bool IsScoreBetterThanBest (int score)
	{
		if (score > bestScore) {
			bestScore = score;
			UpdateBestScore ();
			return true;
		} else {
			return false;
		}
	}

	public int GetBestScore ()
	{
		return bestScore;
	}
}
