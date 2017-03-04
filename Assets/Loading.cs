using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
	public Image bar;

	IEnumerator Start ()
	{
		AsyncOperation async = Application.LoadLevelAsync ("GrrGeneration");
		bar.fillAmount = async.progress;
		yield return async;


	}
}
