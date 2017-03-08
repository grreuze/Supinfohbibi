using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishAnimator : MonoBehaviour {

    private Animator anim;
    private bool faceCam;
    private int lastTrickValue;

    public float trickDuration;

	// Use this for initialization
	void Start () {
        anim = GetComponentInParent<Animator>();
        faceCam = false;
        lastTrickValue = 0;
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
        int newTrickValue;
        do
        {
            newTrickValue = Random.Range(1, 10);
        } while (newTrickValue == lastTrickValue);
        lastTrickValue = newTrickValue;
        anim.SetInteger("Trick_Indexer", newTrickValue);
        anim.SetTrigger("Trick_Trigger");
        StartCoroutine(waitinfEndAnim());
    }

    private IEnumerator waitinfEndAnim()
    {
        yield return new WaitForSeconds(trickDuration);
        SetEndOfTrick();
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
