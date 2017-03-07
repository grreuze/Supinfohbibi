using UnityEngine;

public class TriggerDescending : MonoBehaviour
{

	void OnTriggerEnter (Collider other)
	{
        Fish fish = other.gameObject.GetComponent<Fish>();
        if (fish) {
            fish.SetDescending(false);
		}
	}

	void OnTriggerExit (Collider other) {
        Fish fish = other.gameObject.GetComponent<Fish>();
        if (fish) {
            fish.SetDescending(true);
        }
	}
}
