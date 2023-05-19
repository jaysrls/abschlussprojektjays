using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemCollector : MonoBehaviour
{
    private void Start() {
        globalVariables.itemsCollected = 0;    
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("consumable")){
            Destroy(other.gameObject);
            globalVariables.itemsCollected += 1;
        }
    }
}
