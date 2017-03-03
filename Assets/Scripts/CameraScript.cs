using UnityEngine;

public class CameraScript : MonoBehaviour {

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
    
    public Vector3 cameraOffset = new Vector3(0, 4, 0);

    public float speed = 20;

    public Transform follower;

    public CameraState idle, descending, turningLeft, turningRight, end;
    [HideInInspector]
    public CameraState currentState;

    private FollowerScript followScript;

    private Vector3 originalPos;
    private Vector3 orignialRot;
    
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
        transform.localPosition = Vector3.Slerp(transform.position, follower.position + transform.TransformDirection(cameraOffset), speed*Time.deltaTime);
        transform.localRotation = Quaternion.Slerp(transform.rotation, follower.rotation, speed*Time.deltaTime);
    }

    public void SetNewState(CameraState newState) {
        currentState = newState;
        cameraOffset = currentState.cameraOffset;
        if (followScript)
            followScript.offset = currentState.followOffset;
    }

    public void SetFollower(FollowerScript target) {
        followScript = target;
        follower = target.transform;
    }
}
