using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerScript : MonoBehaviour {

    private float baseY;

    public void ChangeValue(float value) {
        transform.localPosition = new Vector3(transform.localPosition.x, baseY + value, transform.localPosition.z);
    }    private void Start()
    {
        baseY = transform.localPosition.y;
    }    private void Update()
    {
        transform.LookAt(transform.parent.transform);
    }

}
