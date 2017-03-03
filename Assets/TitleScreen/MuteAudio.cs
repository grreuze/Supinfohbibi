using UnityEngine;

public class MuteAudio : MonoBehaviour {
	public GameObject SpriteOn;
	public GameObject SpriteOff;
    
	void Start () {
		AudioListener.pause = GameManager.GetInstance ().soundPause;
	}

	public void OnClicked () {
		AudioManager.ins.PlaySoundAtPosition ("SmallPok", gameObject, false);
		AudioListener.pause = !AudioListener.pause;
	}

	void Update () {
		if (AudioListener.pause == false) {
			GameManager.GetInstance ().soundPause = false;
			SpriteOn.SetActive (true);
			SpriteOff.SetActive(false);
		}

		if (AudioListener.pause == true) {
			GameManager.GetInstance ().soundPause = true;
			SpriteOn.SetActive (false);
			SpriteOff.SetActive(true);
		}
	}
    
}