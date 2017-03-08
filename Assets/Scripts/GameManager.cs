using UnityEngine;

public class GameManager : MonoBehaviour
{

	private static GameManager instance;
	[SerializeField]
	private bool playAuto;
	private Metrics _metrics;

	private void Awake ()
	{
		if (instance != null && instance != this) {
			Destroy (gameObject);
		} else {
			instance = this;
			DontDestroyOnLoad (gameObject);
		}
	}

	void Start ()
	{
		_metrics = Metrics.GetInstance ();
		Screen.orientation = ScreenOrientation.Portrait;
		endRun = GetComponent<EndRun> ();
		_metrics.Setup ();
		endRun.OnRunStart ();
		trickSystem = FindObjectOfType<Trick_Pattern> ();
		if (playAuto)
			SpawnFishes ();
		_bestScore = endRun.PlayerStats.bestScore;
		UpdateBestScore ();
	}

	public static GameManager GetInstance ()
	{
		return instance;
	}

	public bool isPlaying = false;
	/*public float baseMoveSpeed;
    public float accelerateMoveSpeed;
    public float boostMoveSpeed;*/
	public float timeToLosingAcceleration;
	public bool deceleratingLerp_BoostToAccelerate;
	public float timeToLosingBoost;
	public float JumpForce;
	public float _playerStartMoveSpeed;
	public float _maxMoveSpeed;
	public float _minMoveSpeed;
    
	public GameObject _fish;
	public AIFish aiFish;
	public Canvas _endCanvas;
	public bool soundPause = false;
	public int coins;

	private Trick_Pattern trickSystem;
	private int _bestScore = 0;
	private EndRun endRun;

	[System.Serializable]
	public struct AI
	{
		public float baseMoveSpeed;
		public float accelerateMoveSpeed;
		public float chanceToAccelerate;
	}

	public AI[] opponents;

	public void UpdateBestScore ()
	{
		foreach (BestScore best in FindObjectsOfType<BestScore>()) {
			best.UpdateBestScore (coins);
		}
	}

	public void SpawnFishes ()
	{
		Instantiate (_fish, transform.position, transform.rotation);
		for (int i = 0; i < opponents.Length; i++) {
			Vector3 spawnPosition = transform.position;
			spawnPosition.x += Random.Range (-2, 2);
			spawnPosition.z += Random.Range (-2, 2);

			AIFish newFish = Instantiate (aiFish, spawnPosition, transform.rotation);
			newFish.baseMoveSpeed = opponents [i].baseMoveSpeed;
			newFish.accelerateMoveSpeed = opponents [i].accelerateMoveSpeed;
			newFish.chanceToAccelerate = opponents [i].chanceToAccelerate;
		}
		isPlaying = true;
		StartRun ();
		_metrics.StartRun ();
	}

	public void EndRun ()
	{
		if (!trickSystem)
			trickSystem = FindObjectOfType<Trick_Pattern> ();
		trickSystem.EndOfTrick (); 
        
		GameObject.Find ("HUD").GetComponent<Canvas> ().enabled = false;

		CameraScript camera = Camera.main.GetComponent<CameraScript> ();
		camera.SetNewState (camera.end);
        
		AudioManager.GetInstance ().PlaySoundAtPosition ("End", GameObject.Find ("Music").GetComponent<AudioSource> (), true);
		AudioManager.GetInstance ().PlaySoundAtPosition ("CalmFlow", GameObject.Find ("WaterSound").GetComponent<AudioSource> (), true);

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
		if (score > _bestScore) {
			_bestScore = score;
			UpdateBestScore ();
			return true;
		} else {
			return false;
		}
	}

	public int GetBestScore ()
	{
		return _bestScore;
	}

	public void SetEndCanvas (Canvas newCanvas)
	{
		_endCanvas = newCanvas;
	}
}
