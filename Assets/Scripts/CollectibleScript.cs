using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleScript : MonoBehaviour {

    public int scoreToAdd;
    public int bigComboBonus;

    static int combo;

    private void ResetCombo()
    {
        CollectibleScript.combo = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //si le joueur est un player
        if(collision.gameObject.tag == "Player")
        {
            //Si le combo est en cours
            if(CollectibleScript.combo < 5)
            {
                CancelInvoke();
                //collision.gameObject.GetComponent<Truc>().score += scoreToAdd;
                CollectibleScript.combo++;
                Invoke("ResetCombo", 0.5f);
            }
            else
            {
                //collision.gameObject.GetComponent<Truc>().score += (scoreToAdd + bigComboBonus);
                ResetCombo();
            }

            Destroy(gameObject);
        }
    }

}
