using UnityEngine;

public class TriggerJump : MonoBehaviour {

    public float jumpStrength = 1;

    private void OnTriggerEnter(Collider other) {
        FishJumping tmp = other.GetComponentInParent<FishJumping>();
        FishController ctrl = other.GetComponentInParent<FishController>();
        if (tmp)
            tmp.CallJump();
        else if (ctrl)
            ctrl.CallJump(jumpStrength);
    }
}
