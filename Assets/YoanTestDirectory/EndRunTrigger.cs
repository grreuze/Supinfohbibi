﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndRunTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        FishMoving fish = other.GetComponent<FishMoving>();
        Opponent opponent = other.GetComponent<Opponent>();
        Rigidbody tmp;
        if (fish)
        {
            fish._movementSpeed = 0;
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