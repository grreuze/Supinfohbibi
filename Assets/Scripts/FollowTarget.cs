using UnityEngine;

public class FollowTarget : MonoBehaviour {

    /// <summary>
    /// The transform the FollowTarget object is following.
    /// </summary>
    public Transform target;
    /// <summary>
    /// The distance between the FollowTarget object and its target.
    /// </summary>
    [HideInInspector]
    public Vector3 distance;

    public Bool3 axis = new Bool3(true);

    Transform my;
    
    void Start() {
        my = transform;
        distance = my.position - target.position;
    }

    void Update() {

        Vector3 targetPosition = target.position;

        if (!axis.x) targetPosition.x = my.position.x;
        if (!axis.y) targetPosition.y = my.position.y;
        if (!axis.z) targetPosition.z = my.position.z;

        my.position = target.position + distance;
    }
}