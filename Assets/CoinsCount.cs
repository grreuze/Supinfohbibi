using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsCount : MonoBehaviour
{
	int coins = 0;
	int lastCoins = 0;

	void Update ()
	{
		coins = GameManager.GetInstance ().coins;

		if (coins != lastCoins) {
			this.gameObject.GetComponent<Text> ().text = "" + coins;
			lastCoins = coins;
		}
	}
}
