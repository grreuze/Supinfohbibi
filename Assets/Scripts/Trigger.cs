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
                Turn(-90, other);
                break;
            case TriggerMode.TurnRight:
                Turn(90, other);
                break;
        }
    }

    void Turn(float angle, Collider other) {
        FishController ctrl = other.GetComponentInParent<FishController>();
        if (ctrl) {
            if (ctrl.lastTrigger == this)
                return;
            
            Vector3 rot = ctrl.targetRotation.eulerAngles;
            rot.y += angle;

            Quaternion newRot = Quaternion.Euler(rot);
            print(ctrl.transform.rotation.eulerAngles + " -> " + newRot.eulerAngles);
            ctrl.Turn(newRot);

            ctrl.lastTrigger = this;
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
        if (ctrl) {
            if (ctrl.lastTrigger == this)
                return;
            ctrl.CallJump(jumpStrength);
            ctrl.lastTrigger = this;
        }
    }
}
