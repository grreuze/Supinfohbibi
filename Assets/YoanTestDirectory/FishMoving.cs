﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FishMoving : MonoBehaviour {

    public float _movementSpeed;
    public float _tickToSpeedRatio;
    public float _speedDevalueByTick;
    public float _gravityMultiplierWhenFallingWithTouch;

    private Rigidbody _rigid;
    private bool _descend;
    private float _lastHeightValue;

    private void Awake() {
        _rigid = GetComponentInParent<Rigidbody>();
        _movementSpeed = GameManager.GetInstance()._playerStartMoveSpeed;
    }

    private void Start() {
        _lastHeightValue = transform.position.y;
    }

    // Update is called once per frame
    private void Update () {
        AscendUpdate();
        _rigid.velocity = new Vector3(0,_rigid.velocity.y,0);
        _rigid.AddRelativeForce(-Vector3.right * _movementSpeed);
        if (_descend && Input.GetKey("e"))
        {
            _movementSpeed += _tickToSpeedRatio;
            if (_movementSpeed > GameManager.GetInstance()._maxMoveSpeed) {
                _movementSpeed = GameManager.GetInstance()._maxMoveSpeed;
            }
            _rigid.velocity = new Vector3(_rigid.velocity.x, 0, _rigid.velocity.z);
            _rigid.AddRelativeForce(Physics.gravity * _gravityMultiplierWhenFallingWithTouch);
        }
        UpdateSpeed();
        
	}

    private void UpdateSpeed() {
        _movementSpeed -= _speedDevalueByTick;
        if(_movementSpeed < GameManager.GetInstance()._minMoveSpeed) {
            _movementSpeed = GameManager.GetInstance()._minMoveSpeed;
        }
    }

    private void AscendUpdate() {
        if(transform.position.y < _lastHeightValue) {
            _descend = true;
        }
        else {
            _descend = false;
        }
        _lastHeightValue = transform.position.y;
    }

    public float GetMovementSpeed()
    {
        return _movementSpeed;
    }

    public bool GetDescend()
    {
        return _descend;
    }
}
