using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {

    GameManager gm;

	// Use this for initialization
	void Start () {
        gm = GameManager.instance;
	}
	
	void Update () {
        
        if (((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
            || Input.GetMouseButton(0))) {

            print("touched");
            gm.SpawnFishes();
            Destroy(this);

        }
    }
}
