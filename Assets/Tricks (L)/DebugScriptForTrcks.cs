using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugScriptForTrcks : MonoBehaviour {

    Trick_Pattern trickSystem;
    
	void Start () {
        trickSystem = FindObjectOfType<Trick_Pattern>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("a")) {
            trickSystem.StartOfTrick();
        }
	}
}
