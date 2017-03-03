using UnityEngine;

public class CollectibleScript : MonoBehaviour {

    public int scoreToAdd;
    public int bigComboBonus;

    static int combo = 0;

    ParticleSystem CollectedEffect;

    private void Start()
    {
        CollectedEffect = GetComponentInChildren<ParticleSystem>();
    }

    private void FixedUpdate()
    {
        transform.eulerAngles += new Vector3(0, 5, 0);
    }

    private void ResetCombo()
    {
        CollectibleScript.combo = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //si le joueur est un player
        if(collision.gameObject.tag == "Player")
        {
            //Lecture du son de pickup
            AudioManager.ins.PlayCollectibleSound(combo, gameObject);

            //Si le combo est en cours
            if(CollectibleScript.combo < 5)
            {
                CancelInvoke();
                //collision.gameObject.GetComponent<Truc>().score += scoreToAdd;
                CollectibleScript.combo++;
                Invoke("ResetCombo", 0.5f);

                AudioManager.ins.PlayCollectibleSound(combo, gameObject);
            }
            else //si le combo est complété
            {
                //collision.gameObject.GetComponent<Truc>().score += (scoreToAdd + bigComboBonus);
                ResetCombo();
            }

            CollectedEffect.Emit(1);
            Destroy(gameObject);
        }
    }

}
