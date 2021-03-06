﻿using UnityEngine;

public class SplineWalker : MonoBehaviour {

	public BezierSpline spline;

	public float duration;
    public float damping = 1;

	public bool lookForward, enableGravity;

	public SplineWalkerMode mode;

	private float progress;
	private bool goingForward = true;

    public Vector3 offset;
    private Vector3 position;

    public float speed;

	private void Update () {
		if (goingForward) {
            //progress += Time.deltaTime / duration;


            progress += speed * Time.deltaTime;

			if (progress > 1f) {
				if (mode == SplineWalkerMode.Once) {
                    print("done");
					progress = 1f;
				}
				else if (mode == SplineWalkerMode.Loop) {
					progress -= 1f;
				}
				else {
					progress = 2f - progress;
					goingForward = false;
				}
			}
		}
		else {
            progress -= speed * Time.deltaTime;
			//progress -= Time.deltaTime / duration;
            if (progress < 0f) {
				progress = -progress;
				goingForward = true;
			}
		}

        position = spline.GetPoint(progress) + offset ;
        if (enableGravity)
            position.y = transform.localPosition.y; // Let's not affect y

		transform.localPosition = position;
		if (lookForward) {

            Vector3 lookPosition = (position + spline.GetDirection(progress)) - transform.position;

            lookPosition.y = 0;

            Quaternion rot = Quaternion.LookRotation(lookPosition);

            transform.rotation = rot;

			//transform.LookAt(position + spline.GetDirection(progress));
		}
	}
}