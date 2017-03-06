using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDescending : MonoBehaviour
{

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.GetComponent<Fish> ()) {
			other.gameObject.GetComponent<Fish> ().descending = false;
		}
	}

	void OnTriggerExit (Collider other)
	{
		if (other.gameObject.GetComponent<Fish> ()) {
			other.gameObject.GetComponent<Fish> ().descending = true;
		}
	}
}
