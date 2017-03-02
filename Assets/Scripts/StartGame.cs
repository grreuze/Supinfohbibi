using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {

    GameManager gm;

    [SerializeField]
    Canvas titleScreen, HUD;

	// Use this for initialization
	void Start () {
        gm = GameManager.instance;
        HUD.enabled = false;
	}
	
	void Update () {
        
        if (((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
            || Input.GetMouseButton(0))) {

            print("touched");
            GameManager.instance.SpawnFishes();
            titleScreen.enabled = false;
            HUD.enabled = true;
            Destroy(this);

        }
    }
}
