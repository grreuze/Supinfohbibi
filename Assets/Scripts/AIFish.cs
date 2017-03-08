using UnityEngine;

public class AIFish : Fish {

	[Header("AI"), Range (0, 1)]
	public float chanceToAccelerate = 0.1f;
    
	bool accelerateForThisJump;
	float lastY, lastCheckForAcceleration;
    
	public override void MovementSpeed() {
        float time = Time.time;
		if (time - lastCheckForAcceleration > 3) {
			accelerateForThisJump = Random.value < chanceToAccelerate;
			lastCheckForAcceleration = time;
		}
        if (accelerateForThisJump) {
            if (descending) {
                movementSpeed = accelerateMoveSpeed;
                accelerating = true;
            } else {
                movementSpeed = baseMoveSpeed;
                accelerating = false;
            }
        } else {
            movementSpeed = baseMoveSpeed;
            accelerating = false;
        }
	}

	public override void OutOfBounds() {
		Debug.LogWarning ("An AI Went too far Out of Bounds and has been destroyed");
		Destroy (gameObject);
	}
}
