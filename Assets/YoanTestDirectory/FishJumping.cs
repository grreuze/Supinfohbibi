using UnityEngine;
using System.Collections;

[RequireComponent (typeof(FishMoving))]
[RequireComponent (typeof(Rigidbody))]
[RequireComponent (typeof(CapsuleCollider))]
public class FishJumping : MonoBehaviour
{

	public float _multiplyBonusForJump;
	public float _timeWaitingEndOfJump;
	public float _heightLimitForTricks;

	private Rigidbody _rigid;
	private FishMoving _fishMoving;
	private CapsuleCollider _capscol;
	private bool _onJump;
	private bool _coroutine;
	private bool _trickON;
	private int _nbCoroutine;
	private float _yPosBeforeJumpStart;

	private void Awake ()
	{
		_rigid = GetComponentInParent<Rigidbody> ();
		_fishMoving = GetComponentInParent<FishMoving> ();
		_capscol = GetComponent<CapsuleCollider> ();
	}

	private void Start ()
	{
		_coroutine = false;
		_trickON = false;
		_nbCoroutine = 0;
	}

	public void CallJump (float jumpStrength)
	{
		print ("jump");
		_rigid.AddRelativeForce (new Vector3 (0, _fishMoving.GetMovementSpeed () * jumpStrength, 0));
		_yPosBeforeJumpStart = transform.position.y;
		_onJump = true;
	}

	private void Update ()
	{
		if (_onJump) {
			if (_fishMoving.GetDescend ()) {
				if (Input.GetKeyUp ("e") && !_trickON) {
					_nbCoroutine++;
					StartCoroutine (WaitingGround (_nbCoroutine));
				}
				if (Physics.Raycast (transform.position, -Vector3.up, _capscol.height)) {
					_onJump = false;
					_trickON = false;
					if (!_coroutine) {
						JumpFailure ();
					} else {
						Debug.Log ("Boost - OK");
					}
				}
			}
			if (transform.position.y - _yPosBeforeJumpStart > _heightLimitForTricks && !_trickON) {
				Debug.Log ("tricks");
				_trickON = true;
			}
		}
	}

	public void TricksEnd ()
	{
		_trickON = false;
	}

	private void JumpFailure ()
	{
		Debug.Log ("fail");
	}

	private IEnumerator WaitingGround (int nb)
	{
		_coroutine = true;
		float timer = 0;
		while (timer < _timeWaitingEndOfJump) {
			timer += Time.deltaTime;
			yield return new WaitForEndOfFrame ();
		}
		if (nb == _nbCoroutine) { 
			_coroutine = false;
		}
	}
}
