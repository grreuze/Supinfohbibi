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

    private float distToGround;

    private void Awake()
    {
        _rigid = GetComponentInParent<Rigidbody>();
        _fishMoving = GetComponentInParent<FishMoving>();

        distToGround = GetComponent<Collider>().bounds.extents.y;

    }

    // Use this for initialization
    void Start () {
        _ascend = false;
        _lastPosY = transform.position.y;
        _onJump = false;
    }
	
	// Update is called once per frame
	void Update () {

        _ascend = _lastPosY < transform.position.y;
        
        _lastPosY = transform.position.y;

        Vector3 rayPos = transform.position - Vector3.up * distToGround;

        Debug.DrawLine(rayPos, rayPos - Vector3.right * _raycastMaxRange, Color.red);

        if (_ascend && !_onJump && !Physics.Raycast(rayPos, -Vector3.right, _raycastMaxRange))
        {
            print("FishJumping");
            _rigid.AddRelativeForce(Vector3.up * _fishMoving._movementSpeed * _multiplyBonusForJump);
            _onJump = true;
        }
        
	}
}
