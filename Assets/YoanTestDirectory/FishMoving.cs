using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FishMoving : MonoBehaviour {

    public float _movementSpeed;

    public float gravity;
    public float maxFallingSpeed;

    private Rigidbody _rigid;

    CharacterController controller;

    Vector3 direction;
    float verticalVelocity;
    float reachedMaxSpeed;

    private void Awake() {
        _rigid = GetComponentInParent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }
	
	// Update is called once per frame
	private void Update () {
        float deltaTime = Time.deltaTime;
        

        //_rigid.velocity = new Vector3(0,_rigid.velocity.y,0);
        //_rigid.AddRelativeForce(-Vector3.right * _movementSpeed);


        reachedMaxSpeed = verticalVelocity <= -maxFallingSpeed ? reachedMaxSpeed + deltaTime : 0;

        if (controller.isGrounded) {
            verticalVelocity = -gravity * deltaTime;
        } else if (reachedMaxSpeed == 0)
            verticalVelocity -= gravity * deltaTime;

        direction.x = -_movementSpeed * deltaTime;
        direction.y = verticalVelocity;

        controller.Move(direction);
	}
}
