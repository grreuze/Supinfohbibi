using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public abstract class Fish : MonoBehaviour {

    #region public properties
    public bool drawRays;

    [Header("Speed")]
    public float movementSpeed = 12;
    private float averageSpeed = 0;
    private float totalTimeForAvergaeSpeed = 0;
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
    public float maxDistanceToEndTrigger = 50;

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

    protected bool isGrounded;

    [HideInInspector]
    public float distanceToFloor;

    [HideInInspector]
    public bool accelerating;
    [HideInInspector]
    public bool descending;

    ParticleSystem slideParticle;
    #endregion

    #region Monobehaviour

    void Awake() {
        controller = GetComponent<CharacterController>();
        trickSystem = FindObjectOfType<Trick_Pattern>();
        targetRotation = transform.rotation;
        slideParticle = GetComponentInChildren<ParticleSystem>();
        isGrounded = true;
        descending = true;
    }

    float deltaTime;
    void Update() {
        deltaTime = Time.deltaTime;

        if (stopped)
            return;
        
        if (!isGrounded && controller.isGrounded) {
            isGrounded = true;
        }

        averageSpeed = ((averageSpeed * totalTimeForAvergaeSpeed) + (movementSpeed * deltaTime)) / (totalTimeForAvergaeSpeed + deltaTime);
        totalTimeForAvergaeSpeed += deltaTime;

        MovementSpeed();
        JumpAndGravity();

        if (turning) {
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * turningSpeed * movementSpeed);
            
            if (Time.time - lastTimeTurned > 3 || Mathf.Abs(transform.rotation.eulerAngles.y % 360 - targetRotation.eulerAngles.y % 360) < turnStabilisation) {
                transform.rotation = targetRotation;
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

    #region Movement
    protected bool stopped;
    public void StopMovement() {
        stopped = true;
    }

    public void SetDescending(bool value) {
        descending = value;
    }

    public abstract void MovementSpeed();

    public float GetAverageSpeed() {
        return averageSpeed;
    }

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
                if (lastTrigger != trigger)
                    Turn(angle);
                lastTrigger = trigger;
            }

            //if (hit.collider.GetComponent<EndRunTrigger>() && hit.distance < maxDistanceToEndTrigger) {
            //    Vector3 endPosition = hit.transform.position;
            //    endPosition.y = transform.position.y;

            //    transform.position = Vector3.Lerp(transform.position, endPosition, 0.5f * movementSpeed * Time.deltaTime);
            //}
        }

        if (drawRays) {
            Debug.DrawLine(transform.position + transform.right * stabilisationCheckDistance + transform.forward * 1.5f + Vector3.up*10,
                           transform.position + transform.right * stabilisationCheckDistance + transform.forward * 1.5f - Vector3.up*100, Color.red);

            Debug.DrawLine(transform.position - transform.right * stabilisationCheckDistance + transform.forward * 1.5f + Vector3.up*10,
                           transform.position - transform.right * stabilisationCheckDistance + transform.forward * 1.5f - Vector3.up*100, Color.blue);
        }
        
        bool hitRight = Physics.Linecast(transform.position + transform.right * stabilisationCheckDistance + transform.forward * 1.5f + Vector3.up*10,
                         transform.position + transform.right * stabilisationCheckDistance + transform.forward * 1.5f - Vector3.up*100, out hit);

        bool hitLeft = Physics.Linecast(transform.position - transform.right * stabilisationCheckDistance + transform.forward * 1.5f + Vector3.up*10,
                         transform.position - transform.right * stabilisationCheckDistance + transform.forward * 1.5f - Vector3.up*100, out hit);

        if (!hitRight) 
            horizontalVelocity = -stabilisationSpeed * movementSpeed * deltaTime;
        else if (!hitLeft) 
            horizontalVelocity = stabilisationSpeed * movementSpeed * deltaTime;
        else 
            horizontalVelocity = 0;
    }
    #endregion

    #region Jump & Gravity

    bool jumping;
    float jumpStrength;
    [HideInInspector]
    public float startJumpY;

    public void CallJump() {
        if (isGrounded) {
            jumping = true;
            isGrounded = false;
        }
    }

    void JumpAndGravity() {
        reachedMaxSpeed = verticalVelocity <= -maxFallingSpeed ? reachedMaxSpeed + deltaTime : 0;

        if (jumping) {
            verticalVelocity = GameManager.instance.JumpForce * deltaTime;
            startJumpY = transform.position.y;
            jumping = false;
            slideParticle.Stop();
            StartJump();
            
        } else if (controller.isGrounded) {
            verticalVelocity -= gravity * deltaTime;
            Landing();
            if (slideParticle.isStopped)
                slideParticle.Play();

        } else if (reachedMaxSpeed == 0) {
            verticalVelocity -= gravity * deltaTime;
            //StartTrick();
            RaycastHit hit;
            if (Physics.Linecast(transform.position + Vector3.up * 0.7f, transform.position + Vector3.up*2, out hit) && hit.collider.gameObject.layer != 8) {
                verticalVelocity = -gravity * deltaTime;
            }

        } else if (transform.position.y < -300) {
            OutOfBounds();
        }

        if (accelerating)
            verticalVelocity = -fallingSpeedWhenAccelerating;
    }

    public abstract void OutOfBounds();

    public virtual void StartTrick() { }

    public virtual void Landing() { }

    public virtual void StartJump() { }

    #endregion

    #region Turning
    float lastTimeTurned;
    [HideInInspector]
    public float lastAngle;

    void Turn(float angle) {
        if (Time.time - lastTimeTurned < 1) return;

        Vector3 rot = targetRotation.eulerAngles;
        rot.y += angle;

        Quaternion newRot = Quaternion.Euler(rot);

        turning = true;
        targetRotation = newRot;

        lastAngle = angle;
        lastTimeTurned = Time.time;
    }

    public virtual void TurnCamera(float angle) { }

    public void Turn(Quaternion targetRot) {
        turning = true;
        targetRotation = targetRot;
        lastTimeTurned = Time.time;
    }
    #endregion
}
