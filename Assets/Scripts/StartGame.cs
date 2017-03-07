using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


[RequireComponent(typeof(Canvas))]
[RequireComponent(typeof(AudioSource))]
public class StartGame : MonoBehaviour
{

	private GameManager _gameManager;
    private AudioManager _audioManager;
    private Transform _buttonTeamTransform;
    private Transform _buttonSoundTransform;
    private Transform _bestScoreTextTransform;
    private Canvas _canvas;
    private AudioSource _audioSource;
    private AudioSource _musicAudioSource;
    private AudioSource _waterSoundAudioSource;

    [SerializeField]
	private GameObject _buttonTeam;
    [SerializeField]
	private GameObject _buttonSound;
    [SerializeField]
	private GameObject _bestScoreText;
    [SerializeField]
    private GameObject _music;
    [SerializeField]
    private GameObject _waterSound;
	[SerializeField]
	private Canvas _HUD;



	// Use this for initialization
	void Start ()
	{
        _gameManager = GameManager.GetInstance();
        _audioManager = AudioManager.GetInstance();
        _waterSoundAudioSource = _waterSound.GetComponent<AudioSource>();
        _musicAudioSource = _music.GetComponent<AudioSource>();
        _audioSource = GetComponent<AudioSource>();
        _buttonTeamTransform = _buttonTeam.transform;
        _buttonSoundTransform = _buttonSound.transform;
        _bestScoreTextTransform = _bestScoreText.transform;
        _canvas = GetComponent<Canvas>();
		_audioManager.PlaySoundAtPosition ("Menu", _musicAudioSource, true);
		_audioManager.PlaySoundAtPosition ("CalmFlow", _waterSoundAudioSource, true);
		StartCoroutine ("MenuAnim");	
	}

	public void Go ()
	{

		_audioManager.StopSound (_musicAudioSource);
		_audioManager.PlaySoundAtPosition ("Race", _musicAudioSource, true);

		_audioManager.StopSound (_waterSoundAudioSource);
		_audioManager.PlaySoundAtPosition ("BigRipple", _waterSoundAudioSource, true);

		_audioManager.PlaySoundAtPosition ("BigPok", _audioSource, false);
		_gameManager.SpawnFishes ();
		_HUD.enabled = true;
        //HUD.GetComponentInChildren<Chronometer> ().LaunchTimer ();        
        //Destroy (this);
        _canvas.enabled = false;
	}

	IEnumerator MenuAnim ()
	{
		Vector3 bestScoreStartPos = _bestScoreTextTransform.localPosition;
        //bestScore.transform.localPosition = new Vector3 (bestScore.transform.localPosition.x, bestScore.transform.localPosition.y - 220, bestScore.transform.localPosition.z);
        _bestScoreTextTransform.localPosition += new Vector3(0, -220, 0);

        Vector3 buttonTeamStartPos = _buttonTeamTransform.localPosition;
        //buttonTeam.transform.localPosition = new Vector3 (buttonTeam.transform.localPosition.x, buttonTeam.transform.localPosition.y + 220, buttonTeam.transform.localPosition.z);
        _buttonTeamTransform.localPosition += new Vector3(0, 220, 0);
		_buttonTeamTransform.DOLocalMove (buttonTeamStartPos, 0.8f, false).SetEase (Ease.OutBounce).OnComplete (() => {
			_buttonTeamTransform.DOScale (new Vector3 (1.05f, 1.05f, 1.05f), 0.4f).SetLoops (-1, LoopType.Yoyo);
		});

		Vector3 buttonSoundStartPos = _buttonSoundTransform.localPosition;
        //buttonSound.transform.localPosition = new Vector3 (buttonSound.transform.localPosition.x, buttonSound.transform.localPosition.y + 220, buttonSound.transform.localPosition.z);
        _buttonSoundTransform.localPosition += new Vector3(0, 220, 0);
        _buttonSoundTransform.DOLocalMove (buttonSoundStartPos, 0.8f, false).SetEase (Ease.OutBounce).OnComplete (() => {
			_buttonSoundTransform.DOScale (new Vector3 (1.05f, 1.05f, 1.05f), 0.4f).SetLoops (-1, LoopType.Yoyo);
		});

		yield return new WaitForSeconds (1f);

	
		_bestScoreTextTransform.DOLocalMove (bestScoreStartPos, 0.8f, false).SetEase (Ease.OutCirc);
	
	}


}
