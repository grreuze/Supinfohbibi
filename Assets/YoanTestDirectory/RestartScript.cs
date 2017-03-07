using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

[RequireComponent(typeof(Canvas))]
public class RestartScript : MonoBehaviour {

    [SerializeField]
	private GameObject _buttonMenu;
    [SerializeField]
	private GameObject _buttonRestart;

	// Use this for initialization
	void Start ()
	{
        GameManager.GetInstance().SetEndCanvas(FindObjectOfType<RestartScript>().GetComponent<Canvas>());
		_buttonMenu.transform.DOScale(new Vector3 (1.05f, 1.05f, 1.05f), 0.4f).SetLoops(-1, LoopType.Yoyo);
		_buttonRestart.transform.DOScale(new Vector3 (1.05f, 1.05f, 1.05f), 0.4f).SetLoops(-1, LoopType.Yoyo);
	}

	public void ReloadScene ()
	{
		AudioManager.GetInstance().PlaySoundAtPosition("SmallPok", GetComponent<AudioSource>(), false);
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
