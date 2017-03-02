using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trick_Pattern : MonoBehaviour
{
	public GameObject Points;
	public GameObject Swipe_Selector;

	public RectTransform[] Quarters;

	public GameObject TrickButton_Prefab;

	public int buttonCount = 0;

	private int quarterIndexer;
	private int previousQuarterIndexer;
	private int previousPreviousQuarterIndexer;
	private GameObject[] Buttons;
	private Vector3 spawn;

	Canvas canvas;


	bool test = false;

	//Fonction à délcencher quand la phase de tricks commence
	public void StartOfTrick ()
	{
		if (test == false) {
			
		
			test = true;
			//Afficher le background
			this.GetComponent<RawImage> ().enabled = true;
			//faire Spawn les 2 premiers boutons
			SpawnButton ();
			Invoke ("SpawnButton", 0.5f);
		}
	}

	//Fonction à appeler quand la phase de tricks se termine
	public void EndOfTrick ()
	{
		if (test == true) {
			
		
			test = false;
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
		//Choper le canvas (rescale) + Générer 2 chiffres bullshit pour les previous quarters
		canvas = FindObjectOfType<Canvas> ();
		previousPreviousQuarterIndexer = Random.Range (0, Quarters.Length);

		do {
			previousQuarterIndexer = Random.Range (0, Quarters.Length);
		} while(previousQuarterIndexer == previousPreviousQuarterIndexer);

		//Lancer une phase de tricks
		//StartOfTrick();
	}

	/*void Update ()
	{
		//Full Débug (lancer une phase avec "a")
		if (Input.GetKeyDown ("a")) {
			StartOfTrick ();
		}
	}*/

	//Calcul du spawn des Trick Buttons
	void Spawn ()
	{
		//On choisit dans quel quarters le button va spawn (!= des précédants) 
		do {
			quarterIndexer = Random.Range (0, Quarters.Length);
		} while ((quarterIndexer == previousQuarterIndexer) || (quarterIndexer == previousPreviousQuarterIndexer));
        
		previousPreviousQuarterIndexer = previousQuarterIndexer;
		previousQuarterIndexer = quarterIndexer;

		//Random des coord du spawn des buttons
		float rectWidth = Quarters [quarterIndexer].rect.width * canvas.scaleFactor / 2;
		float rectHeight = Quarters [quarterIndexer].rect.height * canvas.scaleFactor / 2;

		int spawnX = (int)Random.Range (
			             Quarters [quarterIndexer].transform.position.x - rectWidth + (TrickButton_Prefab.GetComponent<RectTransform> ().rect.width / 4), 
			             Quarters [quarterIndexer].transform.position.x + rectWidth - (TrickButton_Prefab.GetComponent<RectTransform> ().rect.width / 4));

		int spawnY = (int)Random.Range (
			             Quarters [quarterIndexer].transform.position.y - rectHeight + (TrickButton_Prefab.GetComponent<RectTransform> ().rect.height / 4), 
			             Quarters [quarterIndexer].transform.position.y + rectHeight - (TrickButton_Prefab.GetComponent<RectTransform> ().rect.height / 4));
        
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
		GameObject TrickButton_Instance;
		TrickButton_Instance = Instantiate (TrickButton_Prefab, spawn, Quaternion.identity, this.gameObject.transform)as GameObject;
		
	}
}


