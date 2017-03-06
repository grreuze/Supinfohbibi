using UnityEngine;

public class TriggerJump : MonoBehaviour {

    public float jumpStrength = 1;

    private void OnTriggerEnter(Collider other) {
        Fish fish = other.GetComponentInParent<Fish>();
        if (fish) 
            fish.CallJump();
    }
}
