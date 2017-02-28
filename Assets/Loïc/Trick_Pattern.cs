﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trick_Pattern : MonoBehaviour
{

	public RectTransform[] Quarters;

	public GameObject TrickButton_Prefab;

	public int buttonCount = 0;

	private int quarterIndexer;
	private int previousQuarterIndexer;
	private int previousPreviousQuarterIndexer;

	private Vector3 spawn;

	void Start ()
	{
		
		previousPreviousQuarterIndexer = Random.Range (0, Quarters.Length);

		do {
			previousQuarterIndexer = Random.Range (0, Quarters.Length);
		} while(previousQuarterIndexer == previousPreviousQuarterIndexer);

		SpawnButton ();
		Invoke ("SpawnButton", 0.5f);
	}

	void Update ()
	{
		if (Input.GetKeyDown ("a")) {
			Debug.Log (previousPreviousQuarterIndexer); 
			Debug.Log (previousQuarterIndexer);
			Debug.Log (quarterIndexer);

		}
	}

	void Spawn ()
	{
		
		do {
			quarterIndexer = Random.Range (0, Quarters.Length);
		} while ((quarterIndexer == previousQuarterIndexer) || (quarterIndexer == previousPreviousQuarterIndexer));

		Debug.Log (previousPreviousQuarterIndexer); 
		Debug.Log (previousQuarterIndexer);
		Debug.Log (quarterIndexer);

		previousPreviousQuarterIndexer = previousQuarterIndexer;
		previousQuarterIndexer = quarterIndexer;


		int spawnX = (int)Random.Range (
			             Quarters [quarterIndexer].transform.position.x - (Quarters [quarterIndexer].GetComponent<RectTransform> ().rect.width / 2) + (TrickButton_Prefab.GetComponent<RectTransform> ().rect.width / 4), 
			             Quarters [quarterIndexer].transform.position.x + (Quarters [quarterIndexer].GetComponent<RectTransform> ().rect.width / 2) - (TrickButton_Prefab.GetComponent<RectTransform> ().rect.width / 4));

		int spawnY = (int)Random.Range (
			             Quarters [quarterIndexer].transform.position.y - (Quarters [quarterIndexer].GetComponent<RectTransform> ().rect.height / 2) + (TrickButton_Prefab.GetComponent<RectTransform> ().rect.height / 4), 
			             Quarters [quarterIndexer].transform.position.y + (Quarters [quarterIndexer].GetComponent<RectTransform> ().rect.height / 2) - (TrickButton_Prefab.GetComponent<RectTransform> ().rect.height / 4));


		spawn = new Vector3 (spawnX, spawnY, 0);
	}

	public void SpawnButton ()
	{
		Spawn ();
		buttonCount++;
		GameObject TrickButton_Instance;
		TrickButton_Instance = Instantiate (TrickButton_Prefab, spawn, Quaternion.identity, this.gameObject.transform)as GameObject;
		
	}
}


