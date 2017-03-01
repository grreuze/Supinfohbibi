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
		//Lorsqu'il est instancié, le trick button chope la valeur qu'il doit afficher, et la conserve
		TrickPanel = GameObject.Find ("TrickPanel"); 
		countTemp = TrickPanel.GetComponent<Trick_Pattern> ().buttonCount;
		this.transform.GetChild (0).GetComponent<Text> ().text = "" + countTemp;
	}

	void Update ()
	{
		//Il s'auto-détruit automatiquement (3 boutons max en même temps, le plus ancien est destroy)
		if (TrickPanel.GetComponent<Trick_Pattern> ().buttonCount - 3 == countTemp) {
			Destroy (this.gameObject);
		}
	}
	
}
