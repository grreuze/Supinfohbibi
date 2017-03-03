using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishAnimator : MonoBehaviour {

    Animator anim; 

	// Use this for initialization
	void Start () {
        anim = GetComponentInParent<Animator>();
	}
	
	
}
