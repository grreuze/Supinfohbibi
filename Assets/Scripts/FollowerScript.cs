using UnityEngine;

public class FollowerScript : MonoBehaviour {

    private float baseY;
    public Vector3 offset = new Vector3(0, 2, 0);
    Vector3 targetPosition;
    Transform target;

    public void ChangeValue(float value) {
        transform.localPosition = new Vector3(transform.localPosition.x, baseY + value, transform.localPosition.z);
    }

    private void Start() {
        target = transform.parent;
        baseY = transform.localPosition.y;
    }

    private void Update() {
        targetPosition = target.position + transform.TransformDirection(offset);
        transform.LookAt(targetPosition);
    }

}
