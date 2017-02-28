using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FishMoving : MonoBehaviour {

    public float _movementSpeed;

    private Rigidbody _rigid;

    private void Awake() {
        _rigid = GetComponentInParent<Rigidbody>();
    }
	
	// Update is called once per frame
	private void Update () {
        _rigid.velocity = new Vector3(0,_rigid.velocity.y,0);
        _rigid.AddRelativeForce(-Vector3.right * _movementSpeed);
	}
}
