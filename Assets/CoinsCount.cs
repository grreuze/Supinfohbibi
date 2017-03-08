using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsCount : MonoBehaviour
{

	public int runCoins;

	int coins = 0;
	int lastCoins = 0;

	void Start ()
	{
		coins = GameManager.GetInstance ().coins;
		lastCoins = GameManager.GetInstance ().coins;
		this.gameObject.GetComponent<Text> ().text = "" + (runCoins);
	}

	void Update ()
	{

		coins = GameManager.GetInstance ().coins;

		runCoins = coins - lastCoins;

		if (coins != lastCoins) {
			this.gameObject.GetComponent<Text> ().text = "" + (runCoins);
		}
	}
}
