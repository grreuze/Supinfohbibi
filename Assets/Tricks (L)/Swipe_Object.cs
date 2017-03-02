using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe_Object : MonoBehaviour
{

	//Bool pour savoir si le mec à touché l'écran avant de le lacher
	bool touchedOnce = false;

	GameObject TrickPanel;

	public Vector3 swipeCoord;

	void Start ()
	{
		//On a besoin de TrickPanel pour déclencher l'arret de la phase de tricks
		TrickPanel = GameObject.Find ("TrickPanel");
	}

	void Update ()
	{
		//Si le joueur touche et slide OU reste appuyé sur le clic gauche et déplace la souris
		if (((Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved)
		    || Input.GetMouseButton (0))) {
            
			//Il a donc touché au moins une fois
			touchedOnce = true;
			//Debug.Log (Input.mousePosition);
			swipeCoord = Input.mousePosition;
            
			transform.position = Camera.main.ScreenToWorldPoint (swipeCoord);
            
			//Plane objPlane = new Plane (Camera.main.transform.forward * -1, this.transform.position);


			/*Ray mRay = Camera.main.ScreenPointToRay (Input.mousePosition);
			float rayDistance;
			if (objPlane.Raycast (mRay, out rayDistance)) {
				print ("Touched");
				transform.position = mRay.GetPoint (rayDistance);
			}*/
		} else {
			//Si il le touche pas
			//Mais qu'il a au moins touché une fois (il lache l'appui)
			if (touchedOnce == true) {
				touchedOnce = false;
				//On arrête la phase
				TrickPanel.GetComponent<Trick_Pattern> ().EndOfTrick ();
			}
		}

	}
}
