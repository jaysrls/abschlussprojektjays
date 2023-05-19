using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class onflagcollision3 : MonoBehaviour
{
    public Collider2D flagCollider;
    public Text itemsCollectedText;
    public int requiredItems;
    private void OnTriggerEnter2D(Collider2D other) {
        
        if (other.CompareTag("Player") && globalVariables.itemsCollected >= requiredItems){
            flagCollider.enabled = false;
            PlayerPrefs.SetFloat("currentscore", globalVariables.timerFloat);
            Invoke("FlagCollision", 2f);
        }
        else{
            itemsCollectedText.color = Color.red;
        }
        if (PlayerPrefs.HasKey("l3hs")){
            if (globalVariables.timerFloat < PlayerPrefs.GetFloat("l3hs")){
            PlayerPrefs.SetFloat("l3hs", globalVariables.timerFloat);
        }
        }
        else{
            PlayerPrefs.SetFloat("l3hs", globalVariables.timerFloat);
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        Invoke("colorBlack", 1f);
    }
    private void colorBlack(){
        itemsCollectedText.color = Color.black;
    }
    private void FlagCollision(){
            SceneManager.LoadScene(0);
    }
}