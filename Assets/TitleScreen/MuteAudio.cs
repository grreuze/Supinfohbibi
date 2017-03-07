using UnityEngine;

public class MuteAudio : MonoBehaviour {
    private GameManager _gameManager;
    private AudioManager _audioManager;
	public GameObject SpriteOn;
	public GameObject SpriteOff;
    
	void Start () {
        _gameManager = GameManager.GetInstance();
        _audioManager = AudioManager.GetInstance();
		AudioListener.pause = _gameManager.soundPause;
	}

	public void OnClicked () {
		_audioManager.PlaySoundAtPosition ("SmallPok", gameObject, false);
		AudioListener.pause = !AudioListener.pause;
	}

	void Update () {
		if (AudioListener.pause == false) {
			_gameManager.soundPause = false;
			SpriteOn.SetActive (true);
			SpriteOff.SetActive(false);
		}

		if (AudioListener.pause == true) {
			_gameManager.soundPause = true;
			SpriteOn.SetActive (false);
			SpriteOff.SetActive(true);
		}
	}
    
}