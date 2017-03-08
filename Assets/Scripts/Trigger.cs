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

    void Jump(Collider other) {
        Fish fish = other.GetComponentInParent<Fish>();
        if (fish) {
            if (fish.lastTrigger == this)
                return;
            fish.CallJump();
            fish.lastTrigger = this;
        }
    }
}
