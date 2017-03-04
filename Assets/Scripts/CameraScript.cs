using UnityEngine;

public class CameraScript : MonoBehaviour {

    [SerializeField]
    bool overrideOffset;

    [System.Serializable]
    public struct CameraState {
        public Vector3 cameraOffset;
        public Vector3 followOffset;

        public CameraState(Vector3 cameraOffset, Vector3 followOffset) {
            this.cameraOffset = cameraOffset;
            this.followOffset = followOffset;
        }

        public static bool operator ==(CameraState a, CameraState b) {
            return a.cameraOffset == b.cameraOffset && a.followOffset == b.followOffset;
        }

        public static bool operator != (CameraState a, CameraState b) {
            return !(a == b);
        }
    }

    public Vector3 relativePosition;
    public Vector3 cameraOffset = new Vector3(0, 4, 0);
    public Vector3 targetOffset;

    public float speed = 20;

    public Transform follower;
    public Transform target;

    public CameraState idle, descending, turningLeft, turningRight, end;
    [HideInInspector]
    public CameraState currentState;

    private FollowerScript followScript;

    private Vector3 originalPos;
    private Vector3 orignialRot;

    Vector3 targetPosition, cameraPosition;
    Quaternion cameraRotation;

    //stockage des positions relatives initiales pour l'idle
    private void Start() {
        originalPos = transform.position;
        orignialRot = transform.eulerAngles;

        SetNewState(idle);
    }

    //méthode pour que la caméra suive le follower
    void LateUpdate()
    {
        if (!follower) return;

        if (!overrideOffset) {
            cameraOffset = Vector3.Lerp(cameraOffset, currentState.cameraOffset, speed * Time.deltaTime);
            targetOffset = Vector3.Lerp(targetOffset, currentState.cameraOffset, speed * Time.deltaTime);
        }

        targetPosition = target.position + target.TransformDirection(targetOffset);

        cameraRotation = Quaternion.LookRotation(targetPosition - transform.position);

        cameraPosition = target.localPosition + target.TransformDirection(relativePosition + cameraOffset);

        transform.localPosition = Vector3.Slerp(transform.position, cameraPosition, speed * Time.deltaTime);
        transform.localRotation = Quaternion.Slerp(transform.rotation, cameraRotation, speed * Time.deltaTime);
    }

    public void SetNewState(CameraState newState) {
        currentState = newState;
    }

    public void SetFollower(FollowerScript target) {
        followScript = target;
        follower = target.transform;
    }
}
