using UnityEngine;

public class TriggerDescending : MonoBehaviour {

	void OnTriggerEnter (Collider other) {
        print("enter: " +other.name);
        Fish fish = other.gameObject.GetComponent<Fish>();
        if (fish) {
            fish.SetDescending(false);
		}
	}

	void OnTriggerExit (Collider other) {
        print("left: " + other.name);
        Fish fish = other.gameObject.GetComponent<Fish>();
        if (fish) {
            fish.SetDescending(true);
        }
	}
}
