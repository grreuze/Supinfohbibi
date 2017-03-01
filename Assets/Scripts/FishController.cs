using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class FishController : MonoBehaviour {

    public float movementSpeed;

    public float gravity;
    public float maxFallingSpeed;
    public float heightLimitForTricks = 2;

    Rigidbody _rigid;
    CharacterController controller;

    Vector3 direction;
    float verticalVelocity, horizontalVelocity;
    float reachedMaxSpeed;

    public bool turning;
    public float turningSpeed = 2;
    public Quaternion targetRotation;

    public Trigger lastTrigger;

    #region Monobehaviour

    void Awake() {
        _rigid = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
        targetRotation = transform.rotation;
    }

    float deltaTime;
    void Update() {
        deltaTime = Time.deltaTime;
        
        reachedMaxSpeed = verticalVelocity <= -maxFallingSpeed ? reachedMaxSpeed + deltaTime : 0;
        
        JumpAndGravity();
        DoHorizontalVelocity();

        //DoOrientation();

        if (turning) {
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * turningSpeed * movementSpeed);

            if (Mathf.Abs(transform.rotation.eulerAngles.y - targetRotation.eulerAngles.y) < 0.5f) {
                transform.rotation = targetRotation;
                turning = false;
            }
        }

        direction.x = horizontalVelocity;
        direction.y = verticalVelocity;
        direction.z = movementSpeed * deltaTime;

        direction = transform.TransformDirection(direction);

        controller.Move(direction);
    }
    #endregion

    void DoHorizontalVelocity() {
        if (controller.isGrounded) {
            bool floorOnTheRight = Physics.Linecast(transform.position, transform.position + transform.right - transform.up);
            bool floorOnTheLeft = Physics.Linecast(transform.position, transform.position - transform.right - transform.up);

            if (floorOnTheLeft && floorOnTheRight) {
                horizontalVelocity = 0;

            } else {
                if (!floorOnTheRight)
                    horizontalVelocity = 2 * deltaTime;

                if (!floorOnTheLeft)
                    horizontalVelocity = -2 * deltaTime;
            }
        }
    }

    #region Jump & Gravity

    bool jumping;
    float jumpStrength;
    float startJumpY;

    void JumpAndGravity() {
        if (jumping) {
            verticalVelocity = jumpStrength * movementSpeed * deltaTime;
            startJumpY = transform.position.y;
            //print("jump -> " + verticalVelocity + "(" + jumpStrength + "*" + movementSpeed + "*" + deltaTime + ")");
            jumping = false;

        } else if (controller.isGrounded) {
            verticalVelocity = -gravity * deltaTime;

        } else if (reachedMaxSpeed == 0) {
            verticalVelocity -= gravity * deltaTime;

            if (transform.position.y - startJumpY > heightLimitForTricks) {
                print("tricks");
            }

        }
    }
    #endregion  

    float lastTimeTurned;
    void Turn(float angle) {
        if (Time.time - lastTimeTurned < 1) return;

        Vector3 rot = targetRotation.eulerAngles;
        rot.y += angle;

        Quaternion newRot = Quaternion.Euler(rot);
        print(transform.rotation.eulerAngles + " -> " + newRot.eulerAngles);

        turning = true;
        targetRotation = newRot;

        lastTimeTurned = Time.time;
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


    // Test for automatic turns, fix later
    void DoOrientation() {

        RaycastHit hit;
        bool wallOnRight = Physics.Linecast(transform.position, transform.position + transform.forward + transform.right, out hit)
                                && !hit.collider.isTrigger && hit.transform.gameObject.layer != 8;
        bool wallOnLeft = Physics.Linecast(transform.position, transform.position + transform.forward - transform.right, out hit)
                                && !hit.collider.isTrigger && hit.transform.gameObject.layer != 8;

        if (wallOnLeft)
            Turn(90);
        if (wallOnRight)
            Turn(-90);

    }

}
