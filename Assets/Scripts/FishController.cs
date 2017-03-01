using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class FishController : MonoBehaviour {

    public float _movementSpeed;

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

    bool jumping;
    float jumpStrength;

    void Awake() {
        _rigid = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }

    float deltaTime;
    void Update() {
        deltaTime = Time.deltaTime;
        
        reachedMaxSpeed = verticalVelocity <= -maxFallingSpeed ? reachedMaxSpeed + deltaTime : 0;
        
        if (jumping) {
            verticalVelocity = jumpStrength * _movementSpeed * deltaTime;
            print("jump -> " + verticalVelocity + "(" + jumpStrength + "*" + _movementSpeed + "*" + deltaTime + ")");
            jumping = false;

        } else if (controller.isGrounded) {
            verticalVelocity = -gravity * deltaTime;

        } else if (reachedMaxSpeed == 0)
            verticalVelocity -= gravity * deltaTime;


        if (turning) {
            RaycastHit hit;
            if (Physics.Linecast(transform.position, transform.position + Vector3.forward * 5, out hit)) {
                Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * turningSpeed);
            } else {
                turning = false;
            }
        }


        direction.x = 0;
        direction.y = verticalVelocity;
        direction.z = _movementSpeed * deltaTime;

        direction = transform.TransformDirection(direction);

        controller.Move(direction);
    }

    public void CallJump(float jumpStrength) {
        jumping = true;
        this.jumpStrength = jumpStrength;
        //_rigid.AddRelativeForce(new Vector3(0, _movementSpeed * jumpStrength, 0));
    }
}
