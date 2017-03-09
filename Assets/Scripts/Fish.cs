using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public abstract class Fish : MonoBehaviour {

    #region public properties

    [Header("Speed")]
    public float movementSpeed = 12;
    public float baseMoveSpeed = 12, accelerateMoveSpeed = 20, boostMoveSpeed = 30;

    [Header("In the Air")]
    public float gravity;
    public float maxFallingSpeed = 0.4f;
    public float fallingSpeedWhenAccelerating = 0.7f;
    public float heightLimitForTricks = 2;
    
    [Header("Stabilisation")]
    public float stabilisationCheckDistance = 2;
    public float stabilisationSpeed = 2;
    #endregion

    #region private properties
    protected GameManager _gameManager;
    private CharacterController controller;
    private ParticleSystem slideParticle;
    private GameObject waterEffect, speedWaterEffect;
    private Transform _transform;

    protected bool stopped;

    private Vector3 direction;
    protected float verticalVelocity, horizontalVelocity;

    private float averageSpeed = 0;
    private float totalTimeForAverageSpeed = 0;

    protected float reachedMaxSpeed;
    protected float distanceToFloor;
    
    protected bool isGrounded, accelerating, descending;

    protected bool jumping;
    float jumpStrength;
    private float startJumpY;

    #endregion

    #region Monobehaviour

    void Awake() {
        _transform = GetComponent<Transform>();
        controller = GetComponent<CharacterController>();
        _gameManager = GameManager.GetInstance();
        slideParticle = _transform.FindChild("P_Slide").GetComponent<ParticleSystem>();
        waterEffect = _transform.FindChild("P_Idle").gameObject;
        speedWaterEffect = _transform.FindChild("P_IdleSpeed").gameObject;
        isGrounded = true;
        verticalVelocity = -maxFallingSpeed;
        descending = true;
    }

    protected float deltaTime;
    void Update() {
        deltaTime = Time.deltaTime;

        if (stopped)
            return;
        
        if (!isGrounded && controller.isGrounded) {
            isGrounded = true;
        }

        averageSpeed = ((averageSpeed * totalTimeForAverageSpeed) + (movementSpeed * deltaTime)) / (totalTimeForAverageSpeed + deltaTime);
        totalTimeForAverageSpeed += deltaTime;

        MovementSpeed();
        JumpAndGravity();

        Stabilisation();

        direction.x = horizontalVelocity;
        direction.y = verticalVelocity * deltaTime;
        direction.z = movementSpeed * deltaTime;
        
        direction = _transform.TransformDirection(direction);

        controller.Move(direction);
    }
    
    #endregion

    #region Movement
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
        if (Physics.Raycast(_transform.position, Vector3.down, out hit) && hit.collider.gameObject.layer != 8) {
            // There's floor under us
            distanceToFloor = hit.distance;
        }
        
        bool hitRight = Physics.Linecast(_transform.position + _transform.right * stabilisationCheckDistance + _transform.forward * 1.5f + Vector3.up*10,
                         _transform.position + _transform.right * stabilisationCheckDistance + _transform.forward * 1.5f - Vector3.up*100, out hit);

        bool hitLeft = Physics.Linecast(_transform.position - _transform.right * stabilisationCheckDistance + _transform.forward * 1.5f + Vector3.up*10,
                         _transform.position - _transform.right * stabilisationCheckDistance + _transform.forward * 1.5f - Vector3.up*100, out hit);

        if (!hitRight) 
            horizontalVelocity = -stabilisationSpeed * movementSpeed * deltaTime;
        else if (!hitLeft) 
            horizontalVelocity = stabilisationSpeed * movementSpeed * deltaTime;
        else 
            horizontalVelocity = 0;
    }
    #endregion

    #region Jump & Gravity
    public void CallJump() {
        if (isGrounded) {
            jumping = true;
            isGrounded = false;
        }
    }

    void SetEffectsActive(bool value) {

        if (value && slideParticle.isStopped)
            slideParticle.Play();
        else if (!value && slideParticle.isPlaying)
            slideParticle.Stop();
        
        waterEffect.SetActive(value && !accelerating);
        speedWaterEffect.SetActive(value && accelerating);
    }

    int nombreDeFramesEnSaut;
    float fallingSpeed;
    void JumpAndGravity() {
        reachedMaxSpeed = verticalVelocity <= -maxFallingSpeed ? reachedMaxSpeed + deltaTime : 0;

        if (jumping) {
            verticalVelocity = _gameManager.JumpForce;
            fallingSpeed = 0;
            startJumpY = _transform.position.y;
            jumping = false;
            SetEffectsActive(false);
            nombreDeFramesEnSaut = 0;
            StartJump();
            
        } else if (controller.isGrounded) {
            if(reachedMaxSpeed == 0)
                verticalVelocity -= gravity * deltaTime;
            Landing();
            SetEffectsActive(true);

        } else if (reachedMaxSpeed == 0) { // I haven't reached max falling speed
            nombreDeFramesEnSaut++;

            fallingSpeed -= gravity * deltaTime;
            verticalVelocity = _gameManager.JumpForce + fallingSpeed; 

            //verticalVelocity = (_gameManager.JumpForce - nombreDeFramesEnSaut * gravity) * deltaTime;
            //verticalVelocity -= gravity * deltaTime;

        } else if (_transform.position.y < -300) {
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
}
