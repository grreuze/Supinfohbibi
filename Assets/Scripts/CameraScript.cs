using UnityEngine;

public class CameraScript : MonoBehaviour {

    [SerializeField]
    bool overrideOffset;

    [System.Serializable]
    public struct CameraState {
        public Vector3 cameraOffset;
        public Vector3 targetOffset;

        public CameraState(Vector3 cameraOffset, Vector3 targetOffset) {
            this.cameraOffset = cameraOffset;
            this.targetOffset = targetOffset;
        }

        public static bool operator ==(CameraState a, CameraState b) {
            return a.cameraOffset == b.cameraOffset && a.targetOffset == b.targetOffset;
        }

        public static bool operator != (CameraState a, CameraState b) {
            return !(a == b);
        }
    }

    public Vector3 relativePosition;
    public Vector3 cameraOffset = new Vector3(0, 4, 0);
    public Vector3 targetOffset;

    public float speed = 20;
    
    public Transform target;

    public float targetFOV = 60;
    public CameraState idle, jumping, descending, turningLeft, turningRight, end;
    [HideInInspector]
    public CameraState currentState;
    
    Vector3 targetPosition, cameraPosition;
    Quaternion cameraRotation;
    new Camera camera;

    //stockage des positions relatives initiales pour l'idle
    private void Start() {
        camera = GetComponent<Camera>();
        SetNewState(idle);
    }

    //méthode pour que la caméra suive le follower
    void LateUpdate() {
        if (!target) return;
        float t = speed * Time.deltaTime;

        if (!overrideOffset) {
            cameraOffset = Vector3.Lerp(cameraOffset, currentState.cameraOffset, t);
            targetOffset = Vector3.Lerp(targetOffset, currentState.targetOffset, t);
        }

        targetPosition = target.position + target.TransformDirection(targetOffset);
        cameraRotation = Quaternion.LookRotation(targetPosition - transform.position);
        cameraPosition = target.position + target.TransformDirection(relativePosition + cameraOffset);

        camera.fieldOfView = Mathf.Lerp(camera.fieldOfView, targetFOV, t);
        transform.localPosition = Vector3.Slerp(transform.position, cameraPosition, t);
        transform.localRotation = Quaternion.Slerp(transform.rotation, cameraRotation, t);
    }

    public void SetNewState(CameraState newState) {
        currentState = newState;
    }
}
