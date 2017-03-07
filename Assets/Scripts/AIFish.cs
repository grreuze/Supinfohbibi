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

		if (Time.time - lastCheckForAcceleration > 3) {
			accelerateForThisJump = Random.value < chanceToAccelerate;
			lastCheckForAcceleration = Time.time;
		}

        if (accelerateForThisJump) {
            if (descending) {
                movementSpeed = GameManager.instance.accelerateMoveSpeed;
                accelerating = true;
            } else {
                movementSpeed = GameManager.instance.baseMoveSpeed;
                accelerating = false;
            }
        } else {
            movementSpeed = GameManager.instance.baseMoveSpeed;
            accelerating = false;
        }
	}

	public override void OutOfBounds ()
	{
		Debug.LogWarning ("An AI Went too far Out of Bounds and has been destroyed");
		Destroy (gameObject);
	}
}
