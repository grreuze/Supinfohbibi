using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTargetWithLerp : MonoBehaviour {

    public Transform target;
    public float speed = 2;

	void Update () {

        transform.position = Vector3.Slerp(transform.position, target.position, speed * Time.deltaTime);
        transform.rotation = Quaternion.Slerp(transform.rotation, target.rotation, speed * Time.deltaTime);

    }
}
