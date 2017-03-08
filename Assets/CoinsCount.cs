using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsCount : MonoBehaviour
{
    private GameManager _gameManager;
    private Text _myText;
	public int runCoins;

	int coins = 0;
	int lastCoins = 0;

	void Start ()
	{
        _gameManager = GameManager.GetInstance();
        _myText = GetComponent<Text>();
		coins = _gameManager.coins;
		lastCoins = coins;
		_myText.text = "" + (runCoins);
	}

	void Update ()
	{
		coins = _gameManager.coins;
		runCoins = coins - lastCoins;
		if (coins != lastCoins) {
			_myText.text = "" + (runCoins);
		}
	}
}
