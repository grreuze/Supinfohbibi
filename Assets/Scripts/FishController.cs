using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FishController : Fish {

    new Renderer renderer;
    bool descending;
    float lastY;

    new CameraScript camera;

    void Start() {
        renderer = GetComponent<Renderer>();
        camera = Camera.main.GetComponent<CameraScript>();
        camera.SetFollower(FindObjectOfType<FollowerScript>());
    }

    public override void MovementSpeed() {
        descending = transform.position.y < lastY;
        lastY = transform.position.y;
        
        if (descending && ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
            || Input.GetMouseButton(0)) && !trickSystem.isPlaying && distanceToFloor > distanceToFloorToAccelerate) {

            if (movementSpeed < speed.max)
                movementSpeed += accelerationFactor;

            accelerating = true;
        } else {
            if (movementSpeed > speed.min)
                movementSpeed -= decelerationFactor;
            accelerating = false;
        }
        renderer.material = accelerating ? acceleratingMaterial : defaultMaterial;
    }

    bool hasAlreadyDoneTricks;
    public override void StartTrick() {
        if (transform.position.y - startJumpY > heightLimitForTricks && !trickSystem.isPlaying && !hasAlreadyDoneTricks) {
            trickSystem.StartOfTrick();
            camera.SetNewState(camera.descending);

            hasAlreadyDoneTricks = true;
        }
    }

    public override void EndTrick() {
        if (trickSystem.isPlaying) {
            trickSystem.EndOfTrick();
        }

        if (!turning && camera.currentState != camera.idle)
            camera.SetNewState(camera.idle);
        hasAlreadyDoneTricks = false;
    }

    public override void TurnCamera(float angle) {
        print("trun camera, angle: " + angle);
        if (angle == 90 && camera.currentState != camera.turningRight) {
            camera.SetNewState(camera.turningRight);
            print("trun right");

        } else if (angle == -90 && camera.currentState != camera.turningLeft) {
            camera.SetNewState(camera.turningLeft);
            print("trun left");
        }
    }

    public override void OutOfBounds() {
        Debug.LogWarning("OUT OF BOUNDS: Restarting the Scene.");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
