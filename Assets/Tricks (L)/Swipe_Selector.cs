using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Swipe_Selector : MonoBehaviour
{
	//On utilise cet objet pour transposer les coordonnées touchées par le joueur sur le canvas
	//Couleur du dernier bouton touché
	public Color touchedColor;
	//Object captant le swipe (coord dans le world)
	public GameObject SwipeObject;
	public int count = 0;

	RectTransform rect;

	void Start ()
	{
		rect = GetComponent<RectTransform> ();
	}

	void Update ()
	{
		rect.SetAsLastSibling ();
		//calcul de coordonnées
		transform.position = Camera.main.WorldToScreenPoint (SwipeObject.transform.position);
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		//Quand il touche les tricks buttons
		if (other.gameObject.tag == "TrickButton") {
			//Si c'est bien le bouton suivant
			if (other.GetComponent<Trick_Button> ().countTemp == count + 1) {
				//Ajoute un compteur; change la couleur et désactive son texte, et spawn le boutton suivant
				count++;
				other.gameObject.GetComponent<RawImage> ().color = touchedColor;
				other.gameObject.GetComponentInChildren<Text> ().enabled = false;
				this.gameObject.transform.parent.GetComponent<Trick_Pattern> ().SpawnButton ();
			}
		}
	}
}
