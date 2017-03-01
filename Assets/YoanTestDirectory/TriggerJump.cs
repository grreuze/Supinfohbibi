using UnityEngine;

public class TriggerJump : MonoBehaviour {

    public float jumpStrength = 1;

    private void OnTriggerEnter(Collider other) {
        FishJumping tmp = other.GetComponentInParent<FishJumping>();
        if (tmp) 
            tmp.CallJump(jumpStrength);
    }
}
