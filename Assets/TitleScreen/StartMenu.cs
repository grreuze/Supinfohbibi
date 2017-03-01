using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class StartMenu : MonoBehaviour
{

	public RectTransform team;
	public RectTransform sound;
	//public Transform play;
	public RectTransform score;


	Vector3 teamPos;
	Vector3 soundPos;
	//Vector3 playPos;
	Vector3 scorePos;


	void Awake ()
	{
		teamPos = team.anchoredPosition3D;
		soundPos = sound.anchoredPosition;
		//playPos = play.localPosition;
		scorePos = score.anchoredPosition;

	}

	void Start ()
	{
		//team.localPosition = Vector3.zero;

		//sound.localPosition = new Vector3 (sound.localPosition.x, sound.localPosition.y - 300f, sound.localPosition.z);

		//play.localPosition = new Vector3 (play.localPosition.x, play.localPosition.y - 80f, play.localPosition.z);

		//score.localPosition = new Vector3 (score.localPosition.x, score.localPosition.y - 300f, score.localPosition.z);
	

		StartCoroutine ("Appear");
	}

	IEnumerator Appear ()
	{
		//yield return new WaitForSeconds (0.5f);
		//play.DOLocalMove (playPos, 0.5f).SetEase (Ease.OutElastic, 20f);

		yield return new WaitForSeconds (0.5f);
		sound.DOLocalMove (soundPos, 0.5f).SetEase (Ease.OutElastic, 20f);
		team.DOLocalMove (teamPos, 0.5f).SetEase (Ease.OutElastic, 20f);

		yield return new WaitForSeconds (0.5f);

		score.DOLocalMove (scorePos, 0.5f).SetEase (Ease.OutElastic, 20f);

		yield return null;
	}
}
