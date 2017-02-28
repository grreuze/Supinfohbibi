using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Swipe_Position : MonoBehaviour
{
	public Color touchedColor;
	public GameObject SwipeObject;
	int count = 0;


	void Update ()
	{
		this.gameObject.GetComponent<RectTransform> ().SetAsLastSibling ();
		this.transform.position = Camera.main.WorldToScreenPoint (SwipeObject.transform.position);

	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "TrickButton") {
			
			if (other.GetComponent<Trick_Button> ().countTemp == count + 1) {
				count++;
				other.gameObject.GetComponent<RawImage> ().color = touchedColor;
				other.gameObject.GetComponentInChildren<Text> ().enabled = false;
				this.gameObject.transform.parent.GetComponent<Trick_Pattern> ().SpawnButton ();
			}
		}
	}
}
