using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraScript : MonoBehaviour {

    public enum CamState
    {
        Idle, 
        AcceleratingDescent,
        Climbing,
        Airtime
    }

    public CamState CState = new CamState();
    
    public Vector3 cameraOffset;

    public float speed = 20;

    public Transform follower;
    private FollowerScript followScript;
    public Rigidbody PlayerRigigBody;

    private Vector3 velocity;
    private Vector3 backwards;

    private Vector3 originalPos;
    private Vector3 orignialRot;

        
    //stockage des positions relatives initiales pour l'idle
    private void Start()
    {
        originalPos = transform.position;
        orignialRot = transform.eulerAngles;
    }

    //méthode pour que la caméra suive le follower
    void LateUpdate()
    {
        if (!follower) return;
        transform.position = Vector3.Slerp(transform.position, follower.position + cameraOffset, speed*Time.deltaTime);
        transform.rotation = Quaternion.Slerp(transform.rotation, follower.rotation, speed*Time.deltaTime);
    }

    private void Update()
    {
        //backwards = PlayerRigigBody.position - Vector3.up;
        if (!followScript)
        {
            if(follower)    
                followScript = follower.GetComponent<FollowerScript>();
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                CameraAccelerateDescent();
            }

            if (Input.GetKeyDown(KeyCode.Z))
            {
                CameraIdle();
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                CameraClimb();
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                CameraAirTime();
            }
        }
    }   

    public void CameraAccelerateDescent()
    {
        if (CState != CamState.AcceleratingDescent)
        {
            CState = CamState.AcceleratingDescent;
            followScript.ChangeValue(0.8f);
            //transform.DORotate(new Vector3(12, 0, 0), 0.7f, RotateMode.LocalAxisAdd);
            //follower.DORotate(new Vector3(12, 0, 0), 0.7f, RotateMode.LocalAxisAdd);
        }
    }

    public void CameraIdle()
    {
        if(CState != CamState.Idle)
        {
            CState = CamState.Idle;
            followScript.ChangeValue(0f);
            //follower.DORotate(orignialRot, 0.7f);
        }
    }

    public void CameraClimb()
    {
        if(CState != CamState.Climbing)
        {
            CState = CamState.Climbing;
            followScript.ChangeValue(-0.2f);
            //follower.DORotate(new Vector3(-8, 0, 0), 0.7f, RotateMode.LocalAxisAdd);
        }
    }

    public void CameraAirTime()
    {
        if(CState != CamState.Airtime)
        {
            CState = CamState.Airtime;
            followScript.ChangeValue(0.4f);
            //follower.DORotate(new Vector3(10, 0, 0), 0.5f, RotateMode.LocalAxisAdd);
        }
    }
}
