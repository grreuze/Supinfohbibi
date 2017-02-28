using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerJump : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        FishJumping tmp = other.GetComponentInParent<FishJumping>();
        if (tmp) {
            tmp.CallJump();
        }
        else {
            Debug.Log(tmp);
        }
    }
}
