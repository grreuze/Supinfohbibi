﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using DG.Tweening;

public class FishController : Fish {

    FishAnimator fishAnim;
    public float distanceToFloorToPlayAirAnim;
    public float InputAmplitudeForJump;
    public float TimeLimitForJump;
    public float TimeLimitBoostWaiting;
    private bool jumpOK;
    private bool boosted;
    private bool lastJumping;
    private float timeAccelerateRemaining;
    
    new Renderer renderer;
    float lastY;
    private Vector3 mousePositionForJump;

    new CameraScript camera;
    ParticleSystem speedParticle;

    float fov;
    public float accelerateFov = 90;
    bool isAccFovOn = false;

    void Start() {
        fishAnim = GetComponentInChildren<FishAnimator>();
        renderer = GetComponent<Renderer>();
        camera = Camera.main.GetComponent<CameraScript>();
        camera.target = transform;

        speedParticle = Camera.main.GetComponentInChildren<ParticleSystem>();
        fov = Camera.main.fieldOfView;
        jumpOK = false;
        timeAccelerateRemaining = 0;
    }

    public override void MovementSpeed() {
        int touchCount = Input.touchCount;
        float deltaTime = Time.deltaTime;

        fishAnim.SetGrounded(distanceToFloorToPlayAirAnim > distanceToFloor);
        fishAnim.SetAccelerate(descending && ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
            || Input.GetMouseButton(0)) && !trickSystem.isPlaying);

        if (!boosted)
        {
            if (!GameManager.instance.deceleratingLerp_AccelerateToBase)
            {
                if (((isGrounded && descending) || !isGrounded)
                    && ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
                       || Input.GetMouseButton(0)) && !trickSystem.isPlaying)
                {

                    movementSpeed = GameManager.instance.accelerateMoveSpeed;

                    accelerating = true;
                    if (speedParticle.isStopped)
                        speedParticle.Play();

                }
                else
                {
                    movementSpeed = GameManager.instance.baseMoveSpeed;

                    accelerating = false;
                    if (speedParticle.isPlaying)
                        speedParticle.Stop();
                }
            }
            else
            {
                if (((isGrounded && descending) || !isGrounded)
                    && ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
                       || Input.GetMouseButton(0)) && !trickSystem.isPlaying)
                {
                    accelerating = true;
                    timeAccelerateRemaining = GameManager.instance.timeToLosingAcceleration;
                }
                else
                {
                    accelerating = false;
                    timeAccelerateRemaining -= deltaTime;
                }
                if (timeAccelerateRemaining <= 0)
                {
                    timeAccelerateRemaining = 0;
                    if (speedParticle.isPlaying)
                        speedParticle.Stop();
                }
                else
                {
                    if (speedParticle.isStopped)
                        speedParticle.Play();
                }
                movementSpeed = Mathf.Lerp(GameManager.instance.baseMoveSpeed, GameManager.instance.accelerateMoveSpeed, timeAccelerateRemaining / GameManager.instance.timeToLosingAcceleration);
            }
        }
        else
        {
            if (GameManager.instance.deceleratingLerp_BoostToAccelerate)
            {
                timeAccelerateRemaining -= deltaTime;
                if (timeAccelerateRemaining <= 0)
                {
                    timeAccelerateRemaining = 0;
                    boosted = false;
                }
                movementSpeed = Mathf.Lerp(GameManager.instance.accelerateMoveSpeed, GameManager.instance.boostMoveSpeed, timeAccelerateRemaining / GameManager.instance.timeToLosingBoost);
            }
            else
            {
                timeAccelerateRemaining -= deltaTime;
                if (timeAccelerateRemaining <= 0)
                {
                    timeAccelerateRemaining = GameManager.instance.timeToLosingAcceleration;
                    movementSpeed = GameManager.instance.accelerateMoveSpeed;
                    boosted = false;
                }
                else
                {
                    movementSpeed = GameManager.instance.boostMoveSpeed;
                }
            }
            accelerating = false;
            if (speedParticle.isStopped)
                speedParticle.Play();
        }
        if(!isGrounded && !lastJumping)
        {
            lastJumping = true;
        }

        if(lastJumping && isGrounded)
        {
            StartCoroutine(WaitBoostCall());
            lastJumping = false;
        }

        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) || Input.GetMouseButtonDown(0)) {
            mousePositionForJump = Input.mousePosition;
            jumpOK = true;
            StartCoroutine(WaitingJump());
        }

        if (Input.GetKeyDown(KeyCode.Space) 
            || (((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) || (Input.GetMouseButtonUp(0)))
            &&  InputAmplitudeForJump < Input.mousePosition.y - mousePositionForJump.y && jumpOK)) {
            CallJump();
        }

        if (accelerating) {
            if (isAccFovOn == false) {
                isAccFovOn = true;
                Camera.main.DOFieldOfView(accelerateFov, 0.3f);

            }
        } else {
            if (isAccFovOn == true) {
                isAccFovOn = false;
                Camera.main.DOFieldOfView(fov, 0.3f);
            }
        }
    }

    private IEnumerator WaitingJump()
    {
        yield return new WaitForSeconds(TimeLimitForJump);
        jumpOK = false;
    }

    private IEnumerator WaitBoostCall()
    {
        print("boostcall");
        float timer = 0;
        while(timer < TimeLimitBoostWaiting)
        {
            Debug.Log(Input.GetMouseButton(0));
            if((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) || Input.GetMouseButton(0))
            {
                print("boosted");
                boosted = true;
                timeAccelerateRemaining = GameManager.instance.timeToLosingBoost;
                timer = TimeLimitBoostWaiting;
            }
            timer += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        print("endcall");
    }

    bool hasAlreadyDoneTricks;
    public override void StartTrick() {
        if (transform.position.y - startJumpY > heightLimitForTricks && !trickSystem.isPlaying && !hasAlreadyDoneTricks) {
            trickSystem.StartOfTrick();
            camera.SetNewState(camera.descending); // Camera Descending

            hasAlreadyDoneTricks = true;
        }
    }

    public override void StartJump() {
        camera.SetNewState(camera.jumping);
    }

    public override void Landing() {
        if (trickSystem.isPlaying) {
            trickSystem.EndOfTrick();
        }
        if (!turning && camera.currentState != camera.idle) {
            camera.SetNewState(camera.idle); // Camera Idle
        }
        else if (turning && 
            ((camera.currentState != camera.turningLeft && lastAngle == -90) || 
             (camera.currentState != camera.turningRight && lastAngle == 90))) {
            TurnCamera(lastAngle);
        }
        hasAlreadyDoneTricks = false;
    }

    public override void TurnCamera(float angle) {
        lastAngle = angle;
        if (angle == 90 && camera.currentState != camera.turningRight) {
            camera.SetNewState(camera.turningRight); 

        } else if (angle == -90 && camera.currentState != camera.turningLeft) {
            camera.SetNewState(camera.turningLeft);
        }
    }

    public override void OutOfBounds() {
        Debug.LogWarning("OUT OF BOUNDS: Restarting the Scene.");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
