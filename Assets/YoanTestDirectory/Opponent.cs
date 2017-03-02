using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Opponent : MonoBehaviour {

    private float _speed;
    private Rigidbody _rigid;

    private void Awake() {
        _rigid = GetComponentInParent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
        _rigid.velocity = new Vector3(0, _rigid.velocity.y, 0);
        _rigid.AddRelativeForce(-Vector3.right * _speed);
    }

    public void CallJump(float jumpStrength)
    {
        _rigid.AddRelativeForce(new Vector3(0, _speed * jumpStrength, 0));
    }

    public void SetSpeed(float speed)
    {
        _speed = speed;
    }

    public float GetSpeed()
    {
        return _speed;
    }
}
