using UnityEngine;

public class FishController : Fish {

    FishAnimator fishAnim;
    public float distanceTofloorForPlayAirAnim;


    new Renderer renderer;
    bool descending;
    float lastY;

    void Start() {
        fishAnim = GetComponentInChildren<FishAnimator>();
        renderer = GetComponent<Renderer>();
        Camera.main.GetComponent<CameraScript>().follower = transform.FindChild("Follow");
    }

    public override void MovementSpeed() {
        fishAnim.SetGrounded(distanceTofloorForPlayAirAnim > distanceToFloor);

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
            hasAlreadyDoneTricks = true;
        }
    }

    public override void EndTrick() {
        if (trickSystem.isPlaying)
            trickSystem.EndOfTrick();
        hasAlreadyDoneTricks = false;
    }
}
