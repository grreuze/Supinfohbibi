using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Fish : MonoBehaviour {

    #region public properties
    [Header("Speed")]
    public float movementSpeed = 12;
    public MinMax speed = new MinMax(10, 30);
    public float accelerationFactor = 1, decelerationFactor = 1;
    public Material defaultMaterial, acceleratingMaterial;
    public float stabilisationCheckDistance = 2;
    public float stabilisationSpeed = 2;

    [Header("In the Air")]
    public float gravity;
    public float maxFallingSpeed;
    public float heightLimitForTricks = 2;

    [Header("Turning")]
    public bool turning;
    public float turningSpeed = 2;
    public Quaternion targetRotation;

    public Trigger lastTrigger;
    #endregion

    #region private properties
    [HideInInspector]
    public Trick_Pattern trickSystem;

    Rigidbody _rigid;
    CharacterController controller;

    Vector3 direction;
    float verticalVelocity, horizontalVelocity;
    float reachedMaxSpeed;

    [HideInInspector]
    public float distanceToFloor;

    #endregion

    #region Monobehaviour

    void Awake() {
        _rigid = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
        trickSystem = FindObjectOfType<Trick_Pattern>();
        targetRotation = transform.rotation;
    }

    float deltaTime;
    void Update() {
        deltaTime = Time.deltaTime;

        if (stopped)
            return;

        MovementSpeed();
        Stabilisation();
        JumpAndGravity();

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

    bool stopped;
    public void StopMovement() {
        stopped = true;
    }

    public virtual void MovementSpeed() { }

    void Stabilisation() {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit)) {
            // There's floor under us
            distanceToFloor = hit.distance;
            Trigger trigger = hit.collider.GetComponent<Trigger>();
            if (trigger) {
                if (trigger.mode == Trigger.TriggerMode.Jump)
                    return;
                float angle = trigger.mode == Trigger.TriggerMode.TurnLeft ? -90 : 90;
                Turn(angle);
                lastTrigger = trigger;
            }
        }

        if (!Physics.Raycast(transform.position + transform.right * stabilisationCheckDistance + transform.forward * 1.5f, Vector3.down, out hit)) {
            horizontalVelocity = -stabilisationSpeed * movementSpeed * deltaTime;
        }
        if (!Physics.Raycast(transform.position - transform.right * stabilisationCheckDistance + transform.forward * 1.5f, Vector3.down, out hit)) {
            horizontalVelocity = stabilisationSpeed * movementSpeed * deltaTime;
        }
    }

    #region Jump & Gravity

    bool jumping;
    float jumpStrength;
    float startJumpY;

    public void CallJump(float jumpStrength) {
        jumping = true;
        this.jumpStrength = jumpStrength;
        //_rigid.AddRelativeForce(new Vector3(0, _movementSpeed * jumpStrength, 0));
    }

    bool hasAlreadyDoneTricks;
    void JumpAndGravity() {
        reachedMaxSpeed = verticalVelocity <= -maxFallingSpeed ? reachedMaxSpeed + deltaTime : 0;

        if (jumping) {
            verticalVelocity = jumpStrength * movementSpeed * deltaTime;
            startJumpY = transform.position.y;
            //print("jump -> " + verticalVelocity + "(" + jumpStrength + "*" + movementSpeed + "*" + deltaTime + ")");
            jumping = false;

            print("JUMP: " + jumpStrength * movementSpeed * deltaTime);

        } else if (controller.isGrounded) {
            verticalVelocity = -gravity * deltaTime;
            hasAlreadyDoneTricks = false;
            if (trickSystem.isPlaying) {
                trickSystem.EndOfTrick();
            }

        } else if (reachedMaxSpeed == 0) {
            verticalVelocity -= gravity * deltaTime;

            if (transform.position.y - startJumpY > heightLimitForTricks && !trickSystem.isPlaying && !hasAlreadyDoneTricks) {
                trickSystem.StartOfTrick();
                hasAlreadyDoneTricks = true;
            }
        }
    }
    #endregion

    #region Turning
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
    #endregion
}
