using UnityEngine;

public class Swipe_Object : MonoBehaviour {

	//Bool pour savoir si le mec à touché l'écran avant de le lacher
	bool touchedOnce = false;
    bool cancelPress;

	Trick_Pattern trickPanel;

	public Vector3 swipeCoord;

	void Start () {
		//On a besoin de TrickPanel pour déclencher l'arret de la phase de tricks
		trickPanel = GameObject.Find("TrickPanel").GetComponent<Trick_Pattern>();
	}

	void Update () {
		//Si le joueur touche et slide OU reste appuyé sur le clic gauche et déplace la souris
		if (((Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved)
		    || Input.GetMouseButton (0))) {

            if (trickPanel.alreadyPressing && cancelPress)
                trickPanel.alreadyPressing = false;

			touchedOnce = true;
			swipeCoord = Input.mousePosition;
            
			transform.position = Camera.main.ScreenToWorldPoint (swipeCoord);
            
		} else if(trickPanel.alreadyPressing &&
          ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
          || Input.GetMouseButtonUp(0))) {
            cancelPress = true;

        } else {
			//Si il le touche pas
			//Mais qu'il a au moins touché une fois (il lache l'appui)
			if (touchedOnce == true && !trickPanel.alreadyPressing) {
				touchedOnce = false;
				//On arrête la phase
				trickPanel.EndOfTrick ();
			}
		}

	}
}
