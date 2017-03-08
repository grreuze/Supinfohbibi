using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Renderer))]
[RequireComponent(typeof(AudioSource))]
public class CollectibleScript : MonoBehaviour
{
    private FishAnimator _fishAnimator;
    private AudioSource _audioSource;
    private Renderer _renderer;
    private GameManager _gameManager;
    private AudioManager _audioManager;

	[Header ("Gros boost")]
	[Range (1, 2)]
	public float boostValue;
	public float boostTime;

	[Header ("Petit Boost")]
	[Range (1, 1.5f)]
	public float smallBoostValue;
	public float smallBoostTime;

	private float originalSpeed;

	static int combo = 0;

	ParticleSystem CollectedEffect;

	private void Start ()
	{
        _gameManager = GameManager.GetInstance();
        _audioManager = AudioManager.GetInstance();
        _renderer = GetComponent<Renderer>();
        _audioSource = GetComponent<AudioSource>();
		originalSpeed = _gameManager._maxMoveSpeed;
		CollectedEffect = GetComponentInChildren<ParticleSystem> ();
		originalSpeed = _gameManager._maxMoveSpeed;
	}

	private void FixedUpdate ()
	{
		transform.eulerAngles += new Vector3 (0, 5, 0);
	}

	private void ResetCombo () {
		CollectibleScript.combo = 0;
	}

	private bool alreadyCalled;

	private void OnTriggerEnter (Collider collision)
	{
		//si le joueur est un player
		if (collision.gameObject.tag == "Player") {

			if (!alreadyCalled) {
				_gameManager.coins++;
				_audioManager.PlayCollectibleSound (combo, _audioSource);
				alreadyCalled = true;
			}

			//Lecture du son de pickup
			_audioManager.PlayCollectibleSound (combo, _audioSource);

			//Si le combo est en cours
			if (CollectibleScript.combo < 4) {
				CancelInvoke ();
                
				CollectibleScript.combo++;
				Invoke ("ResetCombo", 1f);

				//reset des coroutines et de la vitesse pour éviter le stack de coroutines
				StopCoroutine (SmallBoost ());
				_gameManager._maxMoveSpeed = originalSpeed;

				StartCoroutine (SmallBoost ());
                
			} else { //si le combo est complété
                
                collision.GetComponent<FishController>().StartBoost();
                if (_fishAnimator == null)
                    _fishAnimator = FindObjectOfType<FishAnimator>();
                _fishAnimator.SetTrick();
                //StartCoroutine (Boost ());
                //ResetCombo ();
            }

			CollectedEffect.Emit (1);
			_renderer.enabled = false;
			Invoke ("Disable", CollectedEffect.main.duration);
		}
	}

	void Disable ()
	{
		gameObject.SetActive (false);
	}

	private IEnumerator Boost ()
	{
		_gameManager._maxMoveSpeed *= boostValue;

		yield return new WaitForSeconds (boostTime);

		_gameManager._maxMoveSpeed = originalSpeed;
	}

	private IEnumerator SmallBoost ()
	{
		_gameManager._maxMoveSpeed *= smallBoostValue;

		yield return new WaitForSeconds (smallBoostTime);

		_gameManager._maxMoveSpeed = originalSpeed;
	}

}
