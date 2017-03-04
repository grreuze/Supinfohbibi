using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class StartGame : MonoBehaviour
{

	GameManager gm;

	public GameObject buttonTeam;
	public GameObject buttonSound;
	public GameObject bestScore;

	[SerializeField]
	Canvas titleScreen, HUD;

	// Use this for initialization
	void Start ()
	{
		AudioManager.ins.PlaySoundAtPosition ("Menu2", GameObject.Find ("Music"), true);

		gm = GameManager.instance;
		HUD.enabled = false;
		StartCoroutine ("MenuAnim");	
	}

	public void Go ()
	{

		AudioManager.ins.StopSound (GameObject.Find ("Music"));
		AudioManager.ins.PlaySoundAtPosition ("Race1", GameObject.Find ("Music"), true);


		AudioManager.ins.PlaySoundAtPosition ("BigPok", gameObject, false);
		gm.SpawnFishes ();
		titleScreen.enabled = false;
		HUD.enabled = true;
		HUD.GetComponentInChildren<Chronometer> ().LaunchTimer ();        
		Destroy (this);
	}

	IEnumerator MenuAnim ()
	{
		Vector3 bestScoreStartPos = bestScore.transform.transform.localPosition;
		bestScore.transform.localPosition = new Vector3 (bestScore.transform.localPosition.x, bestScore.transform.localPosition.y - 220, bestScore.transform.localPosition.z);

		Vector3 buttonTeamStartPos = buttonTeam.transform.transform.localPosition;
		buttonTeam.transform.localPosition = new Vector3 (buttonTeam.transform.localPosition.x, buttonTeam.transform.localPosition.y + 220, buttonTeam.transform.localPosition.z);
		buttonTeam.transform.DOLocalMove (buttonTeamStartPos, 0.8f, false).SetEase (Ease.OutBounce).OnComplete (() => {
			buttonTeam.transform.DOScale (new Vector3 (1.05f, 1.05f, 1.05f), 0.4f).SetLoops (-1, LoopType.Yoyo);
		});

		Vector3 buttonSoundStartPos = buttonSound.transform.transform.localPosition;
		buttonSound.transform.localPosition = new Vector3 (buttonSound.transform.localPosition.x, buttonSound.transform.localPosition.y + 220, buttonSound.transform.localPosition.z);
		buttonSound.transform.DOLocalMove (buttonSoundStartPos, 0.8f, false).SetEase (Ease.OutBounce).OnComplete (() => {
			buttonSound.transform.DOScale (new Vector3 (1.05f, 1.05f, 1.05f), 0.4f).SetLoops (-1, LoopType.Yoyo);
		});

		yield return new WaitForSeconds (1f);

	
		bestScore.transform.DOLocalMove (bestScoreStartPos, 0.8f, false).SetEase (Ease.OutCirc);

		yield return null;
	
	}


}
