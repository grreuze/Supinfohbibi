using UnityEngine;

public class FishController : Fish {

    new Renderer renderer;
    bool descending, accelerating;
    float lastY;

    void Start() {
        renderer = GetComponent<Renderer>();
        Camera.main.GetComponent<CameraScript>().follower = transform.FindChild("Follow");
    }

    public override void MovementSpeed() {
        descending = transform.position.y < lastY;
        lastY = transform.position.y;
        
        if (descending && ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
            || Input.GetMouseButton(0)) && !trickSystem.isPlaying && distanceToFloor > 1.2f) {

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
    
}
