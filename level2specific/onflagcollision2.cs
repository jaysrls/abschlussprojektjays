using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class onflagcollision2 : MonoBehaviour
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
        if (PlayerPrefs.HasKey("l2hs")){
            if (globalVariables.timerFloat < PlayerPrefs.GetFloat("l2hs")){
            PlayerPrefs.SetFloat("l2hs", globalVariables.timerFloat);
        }
        }
        else{
            PlayerPrefs.SetFloat("l2hs", globalVariables.timerFloat);
        }
        if (PlayerPrefs.GetInt("currentlevel") == 2){
            PlayerPrefs.SetInt("currentlevel", 3);
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
