using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class FishController : MonoBehaviour {

    [Header("Speed")]
    public float movementSpeed = 12;
    public MinMax speed = new MinMax(10, 30);
    public float accelerationFactor = 1, decelerationFactor = 1;
    public Material defaultMaterial, acceleratingMaterial;

    [Header("In the Air")]
    public float gravity;
    public float maxFallingSpeed;
    public float heightLimitForTricks = 2;

    [Header("Turning")]
    public bool turning;
    public float turningSpeed = 2;
    public Quaternion targetRotation;

    public Trigger lastTrigger;


    new Renderer renderer;
    Trick_Pattern trickSystem;

    Rigidbody _rigid;
    CharacterController controller;

    Vector3 direction;
    float verticalVelocity, horizontalVelocity;
    float reachedMaxSpeed;

    float lastY;
    bool descending;
    bool accelerating;

    #region Monobehaviour

    void Awake() {
        _rigid = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
        trickSystem = FindObjectOfType<Trick_Pattern>();
        renderer = GetComponent<Renderer>();
        targetRotation = transform.rotation;
    }

    float deltaTime;
    void Update() {
        deltaTime = Time.deltaTime;

        descending = transform.position.y < lastY;
        lastY = transform.position.y;

        if (descending && Input.GetKey("e") && !controller.isGrounded) {

            if (movementSpeed < speed.max)
                movementSpeed += accelerationFactor;

            accelerating = true;
        } else {

            if (movementSpeed > speed.min)
                movementSpeed -= decelerationFactor;
            accelerating = false;
        }
        
        renderer.material = accelerating ? acceleratingMaterial : defaultMaterial;

        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit)) {
            // There's floor under us
            print("floor");
            Trigger trigger = hit.collider.GetComponent<Trigger>();
            if (trigger) {
                if (trigger.mode == Trigger.TriggerMode.Jump)
                    return;
                print(trigger.mode);
                float angle = trigger.mode == Trigger.TriggerMode.TurnLeft ? -90 : 90;
                Turn(angle);
                lastTrigger = trigger;
            }

        }

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
    bool isInTrick;

    public void CallJump(float jumpStrength) {
        jumping = true;
        this.jumpStrength = jumpStrength;
        //_rigid.AddRelativeForce(new Vector3(0, _movementSpeed * jumpStrength, 0));
    }

    void JumpAndGravity() {

        reachedMaxSpeed = verticalVelocity <= -maxFallingSpeed ? reachedMaxSpeed + deltaTime : 0;

        if (jumping) {
            verticalVelocity = jumpStrength * movementSpeed * deltaTime;
            startJumpY = transform.position.y;
            //print("jump -> " + verticalVelocity + "(" + jumpStrength + "*" + movementSpeed + "*" + deltaTime + ")");
            jumping = false;

        } else if (controller.isGrounded) {
            verticalVelocity = -gravity * deltaTime;
            if (isInTrick) {
                trickSystem.EndOfTrick();
                isInTrick = false;
                print("tricks canceled by landing");
            }


        } else if (reachedMaxSpeed == 0) {
            verticalVelocity -= gravity * deltaTime;

            if (transform.position.y - startJumpY > heightLimitForTricks && !isInTrick) {
                trickSystem.StartOfTrick();
                isInTrick = true;
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
