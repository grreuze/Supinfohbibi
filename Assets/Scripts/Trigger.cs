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
        Fish fish = other.GetComponentInParent<Fish>();
        if (fish) {
            if (fish.lastTrigger == this)
                return;
            
            Vector3 rot = fish.targetRotation.eulerAngles;
            rot.y += angle;

            Quaternion newRot = Quaternion.Euler(rot);
            fish.Turn(newRot);
            fish.lastTrigger = this;

            if (fish.GetComponent<FishController>())
                fish.TurnCamera(angle);
        }
    }

    void Jump(Collider other) {
        Fish fish = other.GetComponentInParent<Fish>();
        if (fish) {
            if (fish.lastTrigger == this)
                return;
            //fish.CallJump(jumpStrength);
            fish.lastTrigger = this;
        }
    }
}
