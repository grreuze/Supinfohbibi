using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trick_Pattern : MonoBehaviour
{
	public GameObject Points;
	public GameObject Swipe_Selector;

	public RectTransform[] quarters;

	public GameObject TrickButton_Prefab;

	public int buttonCount = 0;

	private int quarterIndexer;
	private int previousQuarterIndexer;
	private int previousPreviousQuarterIndexer;
	private GameObject[] Buttons;
	private Vector3 spawn;
    private FishAnimator fishAnim;

    Canvas canvas;
	public bool isPlaying = false;
    public bool alreadyPressing;

	//Fonction à délcencher quand la phase de tricks commence
	public void StartOfTrick ()
	{
		if (isPlaying == false) {
			
            if (((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
            || Input.GetMouseButton(0))) {
                alreadyPressing = true;
            }

			isPlaying = true;
			//Afficher le background
			GetComponent<RawImage>().enabled = true;
			//faire Spawn les 2 premiers boutons
			SpawnButton ();
			Invoke ("SpawnButton", 0.5f);
		}
	}

	//Fonction à appeler quand la phase de tricks se termine
	public void EndOfTrick () {
        if (isPlaying == true) {
            
            //Metrics.ins.LogEndTrick(buttonCount - 2); //Le nombre de boutons spawnés moins 2 -> le nombre de tricks effectués

            if (fishAnim == null)
                fishAnim = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<FishAnimator>();

            fishAnim.SetEndOfTrick();

            isPlaying = false;
			//On remet différents paramètres à 0, on calcule et on affiche les points
			buttonCount = 0;

			Points.GetComponent<Points> ().Calcul ();
			Points.GetComponent<Points> ().ActualiseDisplay ();

			this.GetComponent<RawImage> ().enabled = false;


			Swipe_Selector.GetComponent<Swipe_Selector> ().count = 0;
			//Et on delete tout les trick Buttons restants

			CancelInvoke ();

			Buttons = GameObject.FindGameObjectsWithTag ("TrickButton");
			foreach (GameObject But in Buttons) {
				Destroy (But);
			}
		}
	}
    
	void Start ()
	{
        fishAnim = null;
		//Choper le canvas (rescale) + Générer 2 chiffres bullshit pour les previous quarters
		canvas = GetComponentInParent<Canvas> ();
		previousPreviousQuarterIndexer = Random.Range (0, quarters.Length);

		do {
			previousQuarterIndexer = Random.Range (0, quarters.Length);
		} while(previousQuarterIndexer == previousPreviousQuarterIndexer);

		//Lancer une phase de tricks
		//StartOfTrick();
	}
    
	//Calcul du spawn des Trick Buttons
	void Spawn ()
	{
		//On choisit dans quel quarters le button va spawn (!= des précédants) 
		do {
			quarterIndexer = Random.Range (0, quarters.Length);
		} while ((quarterIndexer == previousQuarterIndexer) || (quarterIndexer == previousPreviousQuarterIndexer));
        
		previousPreviousQuarterIndexer = previousQuarterIndexer;
		previousQuarterIndexer = quarterIndexer;

		//Random des coord du spawn des buttons

        Rect myQuarter = quarters[quarterIndexer].rect;

		float rectWidth  = (myQuarter.width  * canvas.scaleFactor) /2;
		float rectHeight = (myQuarter.height * canvas.scaleFactor) /2;

        Rect button = TrickButton_Prefab.GetComponent<RectTransform>().rect;

        float btnWidth = (button.width * canvas.scaleFactor) / 2;
        float btnHeight = (button.height * canvas.scaleFactor) / 2;
        
        Vector3 quarterPosition = quarters[quarterIndexer].transform.position;

        int spawnX = (int)Random.Range(quarterPosition.x - rectWidth + btnWidth,
                                       quarterPosition.x + rectWidth - btnWidth);

        int spawnY = (int)Random.Range(quarterPosition.y - rectHeight + btnHeight,
                                       quarterPosition.y + rectHeight - btnHeight);

        //Vecteur créé
        spawn = new Vector3 (spawnX, spawnY, 0);
    }

	//Ici on fait vraiment spawn les buttons
	public void SpawnButton ()
	{
		//D'abord on leur calcul leurs coord
		Spawn ();
		//On compte que c'est un bouton de plus
		buttonCount++;
		//Et on instancie
		Instantiate (TrickButton_Prefab, spawn, Quaternion.identity, this.gameObject.transform);
	}
}


