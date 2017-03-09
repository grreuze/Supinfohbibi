using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class FishController : Fish {

    [Header("Player")]
    public float distanceToFloorToPlayAirAnim;
    public float InputAmplitudeForJump;
    public float TimeLimitForJump;
    public float TimeLimitBoostWaiting;

    FishAnimator fishAnim;
    private bool jumpOK;
    private bool waitingBoost;
    private bool boosted;
    private bool lastJumping;
    private float timeAccelerateRemaining;
    private float timerWaitingBoost;
    
    float lastY;
    private Vector3 mousePositionForJump;

    new CameraScript camera;
    ParticleSystem speedParticle;

    float fov;
    public float accelerateFov = 90;

    void Start() {
        fishAnim = GetComponentInChildren<FishAnimator>();
        camera = Camera.main.GetComponent<CameraScript>();
        camera.target = transform;

        speedParticle = Camera.main.GetComponentInChildren<ParticleSystem>();
        fov = Camera.main.fieldOfView;
        jumpOK = false;
        waitingBoost = false;
        timeAccelerateRemaining = 0;
    }
    
    public override void MovementSpeed() {
        int touchCount = Input.touchCount;
        deltaTime = Time.deltaTime;

        fishAnim.SetGrounded(distanceToFloorToPlayAirAnim > distanceToFloor);
        fishAnim.SetAccelerate(descending && ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
            || Input.GetMouseButton(0)));

        if (!boosted) {

            DoJump();
            DoBoostAtReception();

            if (((isGrounded && descending) || !isGrounded)
                && ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
                   || Input.GetMouseButton(0))) {

                accelerating = true;
                timeAccelerateRemaining = _gameManager.timeToLosingAcceleration;
            }
            else {
                accelerating = false;
                if (speedParticle.isPlaying)
                    speedParticle.Stop();
                timeAccelerateRemaining -= deltaTime;
            }
            if (timeAccelerateRemaining <= 0)
                timeAccelerateRemaining = 0;

            else if (speedParticle.isStopped)
                speedParticle.Play();

            movementSpeed = Mathf.Lerp(baseMoveSpeed, accelerateMoveSpeed, timeAccelerateRemaining / _gameManager.timeToLosingAcceleration);
        }
        else {
            if (_gameManager.deceleratingLerp_BoostToAccelerate) {
                timeAccelerateRemaining -= deltaTime;
                if (timeAccelerateRemaining <= 0)
                {
                    timeAccelerateRemaining = 0;
                    boosted = false;
                }
                movementSpeed = Mathf.Lerp(accelerateMoveSpeed, boostMoveSpeed, timeAccelerateRemaining / _gameManager.timeToLosingBoost);
            }
            else {
                timeAccelerateRemaining -= deltaTime;
                if (timeAccelerateRemaining <= 0) {
                    timeAccelerateRemaining = _gameManager.timeToLosingAcceleration;
                    movementSpeed = accelerateMoveSpeed;
                    boosted = false;
                }
                else
                    movementSpeed = boostMoveSpeed;
            }

            accelerating = false;
            if (speedParticle.isStopped)
                speedParticle.Play();

        }

        DoCameraFOV();
    }

    void DoJump() {
        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) || Input.GetMouseButtonDown(0)) {
            mousePositionForJump = Input.mousePosition;
            jumpOK = true;
            StartCoroutine(WaitingJump());
        }

        if (Input.GetKeyDown(KeyCode.Space)
             || (((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) || (Input.GetMouseButtonUp(0)))
             && InputAmplitudeForJump < Input.mousePosition.y - mousePositionForJump.y && jumpOK)) {

            CallJump();
        }
    }

    bool canBoost;
    void DoBoostAtReception() {

        bool inputDown = Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began);

        if (distanceToFloor > 3.5f && !lastJumping)
            canBoost = true;

        if (!waitingBoost && lastJumping) {

            if (inputDown)
                canBoost = false;

            if (canBoost && reachedMaxSpeed > 0 && distanceToFloor < 3.5f && verticalVelocity < 0) {
                waitingBoost = true;
                timerWaitingBoost = 0;
            }
        }
        
        lastJumping = distanceToFloor > 3.5f;

        if (waitingBoost) {
            if (inputDown) {
                StartBoost();
                waitingBoost = false;
            }
            timerWaitingBoost += deltaTime;
            if (timerWaitingBoost > TimeLimitBoostWaiting) {
                waitingBoost = false;
            }
        }
    }

    void DoCameraFOV() {
        float t = (movementSpeed - baseMoveSpeed) / (boostMoveSpeed - baseMoveSpeed);
        camera.targetFOV = Mathf.Lerp(fov, accelerateFov, t);
    }

    private IEnumerator WaitingJump() {
        yield return new WaitForSeconds(TimeLimitForJump);
        jumpOK = false;
    }

    public void StartBoost() {
        boosted = true;
        timeAccelerateRemaining = _gameManager.timeToLosingBoost;
    }

    public override void StartJump() {
        camera.SetNewState(camera.jumping);
    }

    public override void Landing() {

        if (camera.currentState != camera.idle) {
            camera.SetNewState(camera.idle); // Camera Idle
        }
    }

    public override void OutOfBounds() {
        Debug.LogWarning("OUT OF BOUNDS: Restarting the Scene.");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
