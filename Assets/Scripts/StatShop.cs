using UnityEngine;

public class StatShop : MonoBehaviour {

    GameManager _gameManager;
    FishController player;

    float minBaseMoveSpeed;
    float minAccelerateMoveSpeed;
    float minBoostDuration;

    float currentBaseMoveSpeed;
    float currentAccelerateMoveSpeed;
    float currentBoostDuration;

    float maxBaseMoveSpeed;
    float maxAccelerateMoveSpeed;
    float maxBoostDuration;

    int gaugeSteps = 10;

    int stepCost = 10;

	void Start () {
        _gameManager = GameManager.GetInstance();
	}
	
    void IncreaseBaseSpeed() {

        if(_gameManager.coins > stepCost) {

            _gameManager.coins -= stepCost;


        } else {
            // not enough coins to increase value
        }


    }



}
