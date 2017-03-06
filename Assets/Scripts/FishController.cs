﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class FishController : Fish {

    FishAnimator fishAnim;
    public float distanceTofloorForPlayAirAnim;
    
    new Renderer renderer;
    bool descending;
    float lastY;

    new CameraScript camera;
    ParticleSystem speedParticle;

    void Start() {
        fishAnim = GetComponentInChildren<FishAnimator>();
        renderer = GetComponent<Renderer>();
        camera = Camera.main.GetComponent<CameraScript>();
        camera.target = transform;

        speedParticle = Camera.main.GetComponentInChildren<ParticleSystem>();
    }

    public override void MovementSpeed() {
        fishAnim.SetGrounded(distanceTofloorForPlayAirAnim > distanceToFloor);
        fishAnim.SetAccelerate(descending && ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
            || Input.GetMouseButton(0)) && !trickSystem.isPlaying && distanceToFloor > distanceToFloorToAccelerate);

        descending = transform.position.y < lastY;
        lastY = transform.position.y;
        
        if (descending && ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
            || Input.GetMouseButton(0)) && !trickSystem.isPlaying && distanceToFloor > distanceToFloorToAccelerate) {

            /*if (movementSpeed < speed.max)
                movementSpeed += accelerationFactor;*/

            movementSpeed = GameManager.instance.accelerateMoveSpeed;
            accelerating = true;
            if(speedParticle.isStopped)
                speedParticle.Play();

        } else {
            /*
            if (movementSpeed > speed.min)
                movementSpeed -= decelerationFactor;*/
            if(!descending && Input.GetMouseButton(0))
            {
                movementSpeed = GameManager.instance.decelerateMoveSpeed;
            }
            else
            {
                movementSpeed = GameManager.instance.baseMoveSpeed;
            }
            accelerating = false;
            if (speedParticle.isPlaying)
                speedParticle.Stop();
        }
        renderer.material = accelerating ? acceleratingMaterial : defaultMaterial;
    }

    bool hasAlreadyDoneTricks;
    public override void StartTrick() {
        if (transform.position.y - startJumpY > heightLimitForTricks && !trickSystem.isPlaying && !hasAlreadyDoneTricks) {
            trickSystem.StartOfTrick();
            camera.SetNewState(camera.descending); // Camera Descending

            hasAlreadyDoneTricks = true;
        }
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
