using UnityEngine;
using System.Collections;

public class CollectibleScript : MonoBehaviour {

    [Header("Gros boost")]
    [Range(1, 2)]
    public float boostValue;
    public float boostTime;

    [Header("Petit Boost")]
    [Range(1, 1.5f)]
    public float smallBoostValue;
    public float smallBoostTime;

    float originalSpeed;

    static int combo = 0;

    ParticleSystem CollectedEffect;

    private void Start() {
        originalSpeed = GameManager.GetInstance()._maxMoveSpeed;
        CollectedEffect = GetComponentInChildren<ParticleSystem>();
        originalSpeed = GameManager.GetInstance()._maxMoveSpeed;
    }

    private void FixedUpdate() {
        transform.eulerAngles += new Vector3(0, 5, 0);
    }

    private void ResetCombo() {
        CollectibleScript.combo = 0;
    }

    bool alreadyCalled;
    private void OnTriggerEnter(Collider collision)
    {
        //si le joueur est un player
        if(collision.gameObject.tag == "Player")
        {

            if(!alreadyCalled) {
                GameManager.GetInstance().coins++;
                AudioManager.ins.PlayCollectibleSound(combo, gameObject);
                alreadyCalled = true;
            }
            //Lecture du son de pickup

            //Si le combo est en cours
            if(CollectibleScript.combo < 5)
            {
                CancelInvoke();
                
                CollectibleScript.combo++;
                Invoke("ResetCombo", 0.5f);

                //reset des coroutines et de la vitesse pour éviter le stack de coroutines
                StopCoroutine(SmallBoost());
                GameManager.GetInstance()._maxMoveSpeed = originalSpeed;

                StartCoroutine(SmallBoost());

                AudioManager.ins.PlayCollectibleSound(combo, gameObject);
            }
            else //si le combo est complété
            {
                StartCoroutine(Boost());
                ResetCombo();
            }

            CollectedEffect.Emit(1);
            GetComponent<Renderer>().enabled = false;
            Invoke("Disable", CollectedEffect.main.duration);
        }
    }

    void Disable() {
        gameObject.SetActive(false);
    }

    private IEnumerator Boost()
    {
        GameManager.GetInstance()._maxMoveSpeed *= boostValue;

        yield return new WaitForSeconds(boostTime);

        GameManager.GetInstance()._maxMoveSpeed = originalSpeed;
    }

    private IEnumerator SmallBoost()
    {
        GameManager.GetInstance()._maxMoveSpeed *= smallBoostValue;

        yield return new WaitForSeconds(smallBoostTime);

        GameManager.GetInstance()._maxMoveSpeed = originalSpeed;
    }

}
