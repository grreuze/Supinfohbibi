using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishAnimator : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponentInParent<Animator>();
	}
	
	public void SetGrounded(bool newValue)
    {
        anim.SetBool("IsGrounded", newValue);
    }

    public void SetAccelerate(bool newValue)
    {
        anim.SetBool("IsAccelerate", newValue);
    }
}
