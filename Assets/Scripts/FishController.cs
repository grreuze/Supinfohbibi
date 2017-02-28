using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class FishController : MonoBehaviour {

    public float _movementSpeed;

    public float gravity;
    public float maxFallingSpeed;
    
    CharacterController controller;

    Vector3 direction;
    float verticalVelocity;
    float reachedMaxSpeed;

    bool jumping;
    float jumpStrength;

    void Awake() {
        controller = GetComponent<CharacterController>();
    }

    float deltaTime;
    void Update() {
        deltaTime = Time.deltaTime;

        print(verticalVelocity);

        reachedMaxSpeed = verticalVelocity <= -maxFallingSpeed ? reachedMaxSpeed + deltaTime : 0;
        
        if (jumping) {
            verticalVelocity = jumpStrength * _movementSpeed * deltaTime;
            print("jump -> " + verticalVelocity + "(" + jumpStrength + "*" + _movementSpeed + "*" + deltaTime + ")");
            jumping = false;

        } else if (controller.isGrounded) {
            verticalVelocity = -gravity * deltaTime;

        } else if (reachedMaxSpeed == 0)
            verticalVelocity -= gravity * deltaTime;

        direction.x = 0;
        direction.y = verticalVelocity;
        direction.z = _movementSpeed * deltaTime;

        direction = transform.TransformDirection(direction);

        controller.Move(direction);
    }

    public void CallJump(float jumpStrength) {
        jumping = true;
        this.jumpStrength = jumpStrength;
    }
}
