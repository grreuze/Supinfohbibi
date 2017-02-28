using UnityEngine;

public class TriggerJump : MonoBehaviour {

    public float jumpStrength = 1;

    private void OnTriggerEnter(Collider other) {
        FishController tmp = other.GetComponentInParent<FishController>();
        if (tmp) 
            tmp.CallJump(jumpStrength);
    }
}
