using UnityEngine;

public class EndRunTrigger : MonoBehaviour {
    
    private void OnTriggerEnter(Collider other)
    {
        Fish fish = other.GetComponent<Fish>();
        Rigidbody tmp;
        if (fish) {
            fish.movementSpeed = 0;
            fish.StopMovement();
            tmp = fish.GetComponent<Rigidbody>();
            tmp.useGravity = false;
            tmp.velocity = Vector3.zero;

            if (fish.GetComponent<FishController>())
                GameManager.GetInstance().EndRun();
        }
    }
}
