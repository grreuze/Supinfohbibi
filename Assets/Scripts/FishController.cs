using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class FishController : MonoBehaviour {

    public float movementSpeed;

    public float gravity;
    public float maxFallingSpeed;

    Rigidbody _rigid;
    CharacterController controller;

    Vector3 direction;
    float verticalVelocity;
    float reachedMaxSpeed;

    public bool turning;
    public float turningSpeed = 2;
    public Quaternion targetRotation;

    public Trigger lastTrigger;

    bool jumping;
    float jumpStrength;



    void Awake() {
        _rigid = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
        targetRotation = transform.rotation;
    }

    float deltaTime;
    void Update() {
        deltaTime = Time.deltaTime;
        
        reachedMaxSpeed = verticalVelocity <= -maxFallingSpeed ? reachedMaxSpeed + deltaTime : 0;
        
        if (jumping) {
            verticalVelocity = jumpStrength * movementSpeed * deltaTime;
            print("jump -> " + verticalVelocity + "(" + jumpStrength + "*" + movementSpeed + "*" + deltaTime + ")");
            jumping = false;

        } else if (controller.isGrounded) {
            verticalVelocity = -gravity * deltaTime;

        } else if (reachedMaxSpeed == 0)
            verticalVelocity -= gravity * deltaTime;
        
        if (turning) {
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * turningSpeed * movementSpeed);
            
            if (Mathf.Abs(transform.rotation.eulerAngles.y - targetRotation.eulerAngles.y) < 0.5f) {
                transform.rotation = targetRotation;
                turning = false;
            }
        }
        
        direction.x = 0;
        direction.y = verticalVelocity;
        direction.z = movementSpeed * deltaTime;

        direction = transform.TransformDirection(direction);

        controller.Move(direction);
    }

    public void Turn(Quaternion targetRot) {
        turning = true;
        targetRotation = targetRot;
    }

    public void CallJump(float jumpStrength) {
        jumping = true;
        this.jumpStrength = jumpStrength;
        //_rigid.AddRelativeForce(new Vector3(0, _movementSpeed * jumpStrength, 0));
    }
}
