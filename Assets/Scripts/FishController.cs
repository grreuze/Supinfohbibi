using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CharacterController))]
public class FishController : MonoBehaviour {

    public float _movementSpeed;

    public float gravity;
    public float maxFallingSpeed;

    public float _raycastMaxRange;

    float yMargin = 1f;

    Rigidbody _rigid;
    CharacterController controller;

    Vector3 direction;
    float verticalVelocity;
    float reachedMaxSpeed;

    float lastY;

    bool goingUp, jumping;
    private float distToGround;

    private void Awake() {
        _rigid = GetComponentInParent<Rigidbody>();
        controller = GetComponent<CharacterController>();

        lastY = transform.position.y;
        distToGround = GetComponent<Collider>().bounds.extents.y;
        print(distToGround);
    }

    // Update is called once per frame
    private void Update() {
        float deltaTime = Time.deltaTime;

        goingUp = lastY < transform.position.y - yMargin;
        lastY = transform.position.y;

        reachedMaxSpeed = verticalVelocity <= -maxFallingSpeed ? reachedMaxSpeed + deltaTime : 0;

        Vector3 rayPos = transform.position;
        //rayPos.y -= distToGround;
        print(transform.position - rayPos);

        Debug.DrawLine(rayPos, rayPos + Vector3.right * _raycastMaxRange, Color.red);

        if (goingUp && !jumping && !Physics.Raycast(rayPos, Vector3.right, _raycastMaxRange)) {

            print("FishJumping");
            jumping = true;
        }

        if (controller.isGrounded) {
            jumping = false;
            verticalVelocity = -gravity * deltaTime;
        } else if (reachedMaxSpeed == 0)
            verticalVelocity -= gravity * deltaTime;

        direction.x = -_movementSpeed * deltaTime;
        direction.y = verticalVelocity;

        controller.Move(direction);
    }
}
