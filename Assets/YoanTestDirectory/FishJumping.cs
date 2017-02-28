﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(FishMoving))]
[RequireComponent(typeof(Rigidbody))]
public class FishJumping : MonoBehaviour {

    public float _multiplyBonusForJump;
    
    private Rigidbody _rigid;
    private FishMoving _fishMoving;

    private void Awake() {
        _rigid = GetComponentInParent<Rigidbody>();
        _fishMoving = GetComponentInParent<FishMoving>();
    }

    public void CallJump() {
        _rigid.AddRelativeForce(new Vector3(0 , _fishMoving.GetMovementSpeed() * _multiplyBonusForJump , 0));
    }
}
