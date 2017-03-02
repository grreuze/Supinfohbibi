using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndRunTrigger : MonoBehaviour {
    
    private void OnTriggerEnter(Collider other)
    {
        FishController fish = other.GetComponent<FishController>();
        Opponent opponent = other.GetComponent<Opponent>();
        Rigidbody tmp;
        if (fish)
        {
            fish.movementSpeed = 0;
            fish.StopMovement();
            tmp = fish.GetComponent<Rigidbody>();
            tmp.useGravity = false;
            tmp.velocity = Vector3.zero;
            GameManager.GetInstance().EndRun();
        }
        if (opponent)
        {
            opponent.SetSpeed(0);
            tmp = opponent.GetComponent<Rigidbody>();
            tmp.useGravity = false;
            tmp.velocity = Vector3.zero;
        }
    }
}
