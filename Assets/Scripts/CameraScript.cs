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

    public CameraState idle, descending, turningLeft, turningRight, end;
    [HideInInspector]
    public CameraState currentState;
    
    Vector3 targetPosition, cameraPosition;
    Quaternion cameraRotation;

    //stockage des positions relatives initiales pour l'idle
    private void Start() {
        SetNewState(idle);
    }

    //méthode pour que la caméra suive le follower
    void LateUpdate()
    {
        if (!target) return;

        if (!overrideOffset) {
            cameraOffset = Vector3.Lerp(cameraOffset, currentState.cameraOffset, speed * Time.deltaTime);
            targetOffset = Vector3.Lerp(targetOffset, currentState.targetOffset, speed * Time.deltaTime);
        }

        targetPosition = target.position + target.TransformDirection(targetOffset);

        cameraRotation = Quaternion.LookRotation(targetPosition - transform.position);

        cameraPosition = target.position + target.TransformDirection(relativePosition + cameraOffset);

        transform.localPosition = Vector3.Slerp(transform.position, cameraPosition, speed * Time.deltaTime);
        transform.localRotation = Quaternion.Slerp(transform.rotation, cameraRotation, speed * Time.deltaTime);
    }

    public void SetNewState(CameraState newState) {
        currentState = newState;
    }
}
