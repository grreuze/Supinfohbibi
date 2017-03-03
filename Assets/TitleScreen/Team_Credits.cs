using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team_Credits : MonoBehaviour
{

	bool dispCredits = false;
	public GameObject Fade;
	public GameObject Credit;


	public void Clicked ()
	{

		AudioManager.ins.PlaySoundAtPosition ("SmallPok", gameObject, false);

		if (dispCredits == false) {
			dispCredits = true;
			Fade.GetComponent<Animation> ().Play ("Fade_In_Credits_Anim");
			Credit.GetComponent<Animation> ().Play ("Team_Credits_In_Anim");
			Fade.SetActive (true);
		} else if (dispCredits == true) {
			dispCredits = false;
			Fade.GetComponent<Animation> ().Play ("Fade_Out_Credits_Anim");
			Credit.GetComponent<Animation> ().Play ("Team_Credits_Out_Anim");
			Fade.SetActive (false);
		}

	}

}
