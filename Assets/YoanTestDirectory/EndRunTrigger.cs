using UnityEngine;

public class EndRunTrigger : MonoBehaviour {

    private bool trigger = true;

    private void OnTriggerEnter(Collider other)
    {
        Fish fish = other.GetComponent<Fish>();
        Rigidbody tmp;
        if (fish){
            fish.movementSpeed = 0;
            fish.StopMovement();
            tmp = fish.GetComponent<Rigidbody>();
            tmp.useGravity = false;
            tmp.velocity = Vector3.zero;


            if (trigger)
            {
                if (fish.GetComponent<FishController>())
                {
                    GameManager.GetInstance().EndRun();
                    trigger = false;

                }
            }
        }
    }
}
