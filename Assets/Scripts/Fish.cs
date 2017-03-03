using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public abstract class Fish : MonoBehaviour {

    #region public properties
    [Header("Speed")]
    public float movementSpeed = 12;
    public MinMax speed = new MinMax(10, 30);
    public float accelerationFactor = 1, decelerationFactor = 1;
    public float distanceToFloorToAccelerate = 1.2f;
    public Material defaultMaterial, acceleratingMaterial;
    public float stabilisationCheckDistance = 2;
    public float stabilisationSpeed = 2;

    [Header("In the Air")]
    public float gravity;
    public float maxFallingSpeed = 0.4f;
    public float fallingSpeedWhenAccelerating = 0.7f;
    public float heightLimitForTricks = 2;

    [Header("Turning")]
    public bool turning;
    public float turningSpeed = 2;
    public Quaternion targetRotation;
    public float turnStabilisation = 2;

    public Trigger lastTrigger;
    #endregion

    #region private properties
    [HideInInspector]
    public Trick_Pattern trickSystem;

    CharacterController controller;

    Vector3 direction;
    float verticalVelocity, horizontalVelocity;
    float reachedMaxSpeed;

    [HideInInspector]
    public float distanceToFloor;

    [HideInInspector]
    public bool accelerating;

    #endregion

    #region Monobehaviour

    void Awake() {
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
        JumpAndGravity();

        if (turning) {
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * turningSpeed * movementSpeed);

            if (Mathf.Abs(transform.rotation.eulerAngles.y - targetRotation.eulerAngles.y) < turnStabilisation) {
                transform.rotation = targetRotation;
                print("end turn");
                turning = false;
            }
        }

        Stabilisation();

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

    public abstract void MovementSpeed();

    void Stabilisation() {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit) && hit.collider.gameObject.layer != 8) {
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

            if (hit.collider.GetComponent<EndRunTrigger>()) {
                Vector3 endPosition = hit.transform.position;
                endPosition.y = transform.position.y;

                transform.position = Vector3.Lerp(transform.position, endPosition, 0.5f * movementSpeed * Time.deltaTime);
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
    [HideInInspector]
    public float startJumpY;

    public void CallJump(float jumpStrength) {
        if (controller.isGrounded) {
            jumping = true;
            this.jumpStrength = jumpStrength;
        }
    }

    void JumpAndGravity() {
        reachedMaxSpeed = verticalVelocity <= -maxFallingSpeed ? reachedMaxSpeed + deltaTime : 0;

        if (jumping) {
            verticalVelocity = jumpStrength * movementSpeed * deltaTime;
            startJumpY = transform.position.y;
            jumping = false;
            
        } else if (controller.isGrounded) {
            verticalVelocity = -gravity * deltaTime;
            EndTrick();

        } else if (reachedMaxSpeed == 0) {
            verticalVelocity -= gravity * deltaTime;
            StartTrick();
        } else if (transform.position.y < -300) {
            OutOfBounds();
        }

        if (accelerating)
            verticalVelocity = -fallingSpeedWhenAccelerating;
    }

    public abstract void OutOfBounds();

    public virtual void StartTrick() { }

    public virtual void EndTrick() { }

    #endregion

    #region Turning
    float lastTimeTurned;
    void Turn(float angle) {
        if (Time.time - lastTimeTurned < 1) return;

        Vector3 rot = targetRotation.eulerAngles;
        rot.y += angle;

        Quaternion newRot = Quaternion.Euler(rot);

        turning = true;
        targetRotation = newRot;

        lastTimeTurned = Time.time;
    }

    public virtual void TurnCamera(float angle) { }

    public void Turn(Quaternion targetRot) {
        turning = true;
        targetRotation = targetRot;
    }
    #endregion
}
