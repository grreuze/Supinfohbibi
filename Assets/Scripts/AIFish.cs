using UnityEngine;

public class AIFish : Fish {

    [Range(0, 1)]
    public float chanceToAccelerate = 0.1f;

    new Renderer renderer;
    bool descending;
    bool accelerateForThisJump;
    float lastY, lastCheckForAcceleration;

    void Start() {
        renderer = GetComponent<Renderer>();
    }

    public override void MovementSpeed() {
        descending = transform.position.y < lastY;
        lastY = transform.position.y;

        if (Time.time - lastCheckForAcceleration > 3) {
            accelerateForThisJump = Random.value < chanceToAccelerate;
            lastCheckForAcceleration = Time.time;
        }

        if (descending && accelerateForThisJump && !trickSystem.isPlaying && distanceToFloor > distanceToFloorToAccelerate) {

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

    public override void OutOfBounds() {
        Debug.LogWarning("An AI Went too far Out of Bounds and has been destroyed");
        Destroy(gameObject);
    }
}
