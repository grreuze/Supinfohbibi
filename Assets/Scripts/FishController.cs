using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class FishController : Fish {

    FishAnimator fishAnim;
    public float distanceTofloorForPlayAirAnim;
    
    new Renderer renderer;
    float lastY;
    private Vector3 mousePositionForJump;

    new CameraScript camera;
    ParticleSystem speedParticle;

    float fov;
    public float accelerateFov = 90;
    bool isAccFovOn = false;

    void Start() {
        fishAnim = GetComponentInChildren<FishAnimator>();
        renderer = GetComponent<Renderer>();
        camera = Camera.main.GetComponent<CameraScript>();
        camera.target = transform;

        speedParticle = Camera.main.GetComponentInChildren<ParticleSystem>();
        fov = Camera.main.fieldOfView;
    }

    public override void MovementSpeed() {
        int touchCount = Input.touchCount;

        fishAnim.SetGrounded(distanceTofloorForPlayAirAnim > distanceToFloor);
        fishAnim.SetAccelerate(descending && ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
            || Input.GetMouseButton(0)) && !trickSystem.isPlaying);
        
        if (descending && ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
            || Input.GetMouseButton(0)) && !trickSystem.isPlaying) {

            movementSpeed = GameManager.instance.accelerateMoveSpeed;

            accelerating = true;
            if(speedParticle.isStopped)
                speedParticle.Play();

        } else {
            if (!descending && Input.GetMouseButton(0)) {
                movementSpeed = GameManager.instance.decelerateMoveSpeed;
            } else {
                movementSpeed = GameManager.instance.baseMoveSpeed;
            }
            accelerating = false;
            if (speedParticle.isPlaying)
                speedParticle.Stop();
        }
        renderer.material = accelerating ? acceleratingMaterial : defaultMaterial;
        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) || Input.GetMouseButtonDown(0)) {
            mousePositionForJump = Input.mousePosition;
        }

        if (Input.GetKeyDown(KeyCode.Space) 
            || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) 
            || (Input.GetMouseButtonUp(0) && mousePositionForJump.y < Input.mousePosition.y)) {

            CallJump();
        }

        if (accelerating) {
            if (isAccFovOn == false) {
                isAccFovOn = true;
                Camera.main.DOFieldOfView(accelerateFov, 0.3f);

            }
        } else {
            if (isAccFovOn == true) {
                isAccFovOn = false;
                Camera.main.DOFieldOfView(fov, 0.3f);
            }
        }
    }

    bool hasAlreadyDoneTricks;
    public override void StartTrick() {
        if (transform.position.y - startJumpY > heightLimitForTricks && !trickSystem.isPlaying && !hasAlreadyDoneTricks) {
            trickSystem.StartOfTrick();
            camera.SetNewState(camera.descending); // Camera Descending

            hasAlreadyDoneTricks = true;
        }
    }

    public override void StartJump() {
        camera.SetNewState(camera.jumping);
    }

    public override void Landing() {
        if (trickSystem.isPlaying) {
            trickSystem.EndOfTrick();
        }
        if (!turning && camera.currentState != camera.idle) {
            camera.SetNewState(camera.idle); // Camera Idle
        }
        else if (turning && 
            ((camera.currentState != camera.turningLeft && lastAngle == -90) || 
             (camera.currentState != camera.turningRight && lastAngle == 90))) {
            TurnCamera(lastAngle);
        }
        hasAlreadyDoneTricks = false;
    }

    public override void TurnCamera(float angle) {
        lastAngle = angle;
        if (angle == 90 && camera.currentState != camera.turningRight) {
            camera.SetNewState(camera.turningRight); 

        } else if (angle == -90 && camera.currentState != camera.turningLeft) {
            camera.SetNewState(camera.turningLeft);
        }
    }

    public override void OutOfBounds() {
        Debug.LogWarning("OUT OF BOUNDS: Restarting the Scene.");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
