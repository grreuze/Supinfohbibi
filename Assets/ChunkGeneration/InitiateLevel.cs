using System.Collections;
using UnityEngine;

public class InitiateLevel : MonoBehaviour {

    LevelGeneration lvlGen;
    
	void Start () {
        lvlGen = LevelGeneration.ins;
        StartCoroutine(_GenerateLevel());
	}
	
    IEnumerator _GenerateLevel() {

        for (int i = 0; i < lvlGen.runLength+1; i++) {
            //lvlGen.Generate();
            yield return null;
        }
        print("Done Generating");
    }

}
