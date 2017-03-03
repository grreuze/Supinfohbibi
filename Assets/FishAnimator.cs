using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishAnimator : MonoBehaviour {

    private Animator anim;
    private bool faceCam;

	// Use this for initialization
	void Start () {
        anim = GetComponentInParent<Animator>();
        faceCam = false;
	}
	
	public void SetGrounded(bool newValue)
    {
        anim.SetBool("IsGrounded", newValue);
    }

    public void SetAccelerate(bool newValue)
    {
        anim.SetBool("IsAccelerate", newValue);
    }

    public void SetTrick()
    {
        if (!faceCam)
        {
            faceCam = true;
            transform.Rotate(new Vector3(0, 180, 0));
        }
        anim.SetInteger("Trick_Indexer", Random.Range(1, 10));
        anim.SetTrigger("Trick_Trigger");
    }

    public void SetEndOfTrick()
    {
        if(faceCam)
        {
            faceCam = false;
            transform.Rotate(new Vector3(0, -180, 0));
        }
        anim.SetTrigger("Trick_End");
    }
}
