using UnityEngine;

public class AIFish : Fish
{

	[Range (0, 1)]
	public float chanceToAccelerate = 0.1f;

	new Renderer renderer;
	bool accelerateForThisJump;
	float lastY, lastCheckForAcceleration;

	void Start () {
		renderer = GetComponent<Renderer> ();
	}

	public override void MovementSpeed () {
        float time = Time.time;
		if (time - lastCheckForAcceleration > 3) {
			accelerateForThisJump = Random.value < chanceToAccelerate;
			lastCheckForAcceleration = time;
		}

        if (accelerateForThisJump) {
            if (descending) {
                movementSpeed = _gameManager.accelerateMoveSpeed;
                accelerating = true;
            } else {
                movementSpeed = _gameManager.baseMoveSpeed;
                accelerating = false;
            }
        } else {
            movementSpeed = _gameManager.baseMoveSpeed;
            accelerating = false;
        }
	}

	public override void OutOfBounds ()
	{
		Debug.LogWarning ("An AI Went too far Out of Bounds and has been destroyed");
		Destroy (gameObject);
	}
}
