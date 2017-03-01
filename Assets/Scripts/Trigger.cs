using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

    public enum TriggerMode {
        Jump,
        TurnLeft,
        TurnRight
    }

    public TriggerMode mode;

    public float jumpStrength = 1;

    private void OnTriggerEnter(Collider other) {

        switch(mode) {
            case TriggerMode.Jump:
                Jump(other);
                break;
            case TriggerMode.TurnLeft:

                break;
            case TriggerMode.TurnRight:

                break;
        }
    }

    void Turn(float angle, Collider other) {
        FishController ctrl = other.GetComponentInParent<FishController>();
        if (ctrl) {
            
        }
    }

    void Jump(Collider other) {
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
