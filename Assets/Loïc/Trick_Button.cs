using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trick_Button : MonoBehaviour
{
	GameObject TrickPanel;
	public int countTemp;

	void Start ()
	{
		TrickPanel = GameObject.Find ("TrickPanel"); 
		countTemp = TrickPanel.GetComponent<Trick_Pattern> ().buttonCount;
		this.transform.GetChild (0).GetComponent<Text> ().text = "" + countTemp;
	}

	void Update ()
	{
		if (TrickPanel.GetComponent<Trick_Pattern> ().buttonCount - 3 == countTemp) {
			Destroy (this.gameObject);
		}
	}
	
}
