using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(FishMoving))]
[RequireComponent(typeof(Rigidbody))]
public class FishJumping : MonoBehaviour {

    public float _raycastMaxRange;
    public float _multiplyBonusForJump;

    private bool _ascend;
    private bool _onJump;
    private float _lastPosY;
    private Rigidbody _rigid;
    private FishMoving _fishMoving;

    private void Awake()
    {
        _rigid = GetComponentInParent<Rigidbody>();
        _fishMoving = GetComponentInParent<FishMoving>();
    }

    // Use this for initialization
    void Start () {
        _ascend = false;
        _lastPosY = transform.position.y;
        _onJump = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (_lastPosY < transform.position.y)
        {
            _ascend = true;
        }
        else
        {
            _ascend = false;
        }
        _lastPosY = transform.position.y;
        if (_ascend && !_onJump && !Physics.Raycast(transform.position, -Vector3.right, _raycastMaxRange))
        {
            _rigid.AddRelativeForce(Vector3.up * _fishMoving._movementSpeed * _multiplyBonusForJump);
            _onJump = true;
        }
        
	}
}
