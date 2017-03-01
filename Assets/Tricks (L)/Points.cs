﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{

	//Swipe_Position pour avoir le nombre de boutons touchés
	public GameObject Swipe_Position;
	public int points;
	//Valeur du premier trick button (si le joueur n'en touche qu'un par exemple)
	public int baseValue = 10;

	void Start ()
	{
		ActualiseDisplay ();
	}


	//Calcul des points à ajouter
	public void Calcul ()
	{
		int count = Swipe_Position.GetComponent<Swipe_Selector> ().count;
		Debug.Log (count);
		//Formule de calcul des points en fonction de la valeur de base
		points += (int)(baseValue * Mathf.Pow (1.50f, count));
	}

	//Plutot explicite; pour juste l'appeler au bon moment
	public void ActualiseDisplay ()
	{
		this.gameObject.GetComponent<Text> ().text = "" + points;
	}

}
