using UnityEngine;

public class EndRunTrigger : MonoBehaviour {

    private bool trigger = true;

    private void OnTriggerEnter(Collider other)
    {
        Fish fish = other.GetComponent<Fish>();
        if (fish){
            fish.movementSpeed = 0;
            fish.StopMovement();
            
            if (trigger) {
                if (fish.GetComponent<FishController>()) {
                    GameManager.GetInstance().EndRun();
                    trigger = false;
                }
            }
        }
    }
}
