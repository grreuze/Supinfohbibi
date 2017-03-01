using UnityEngine;

public class TriggerJump : MonoBehaviour {

    public float jumpStrength = 1;

    private void OnTriggerEnter(Collider other) {
        FishJumping tmp = other.GetComponentInParent<FishJumping>();
        FishController ctrl = other.GetComponentInParent<FishController>();
        Opponent op = other.GetComponentInParent<Opponent>();
        if (tmp) 
            tmp.CallJump(jumpStrength);
        if (op)
            op.CallJump(jumpStrength);
        if (ctrl)
            ctrl.CallJump(jumpStrength);
    }
}
