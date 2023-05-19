using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class onflagcollision : MonoBehaviour
{
    public Collider2D flagCollider1;
    public Text itemsCollectedText;
    public int requiredItems;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player") && globalVariables.itemsCollected >= requiredItems){
            flagCollider1.enabled = false;
            PlayerPrefs.SetFloat("currentscore", globalVariables.timerFloat);
            Invoke("FlagCollision", 2f);
        }
        else{
            itemsCollectedText.color = Color.red;
        }
        if (PlayerPrefs.HasKey("l1hs")){
            if (globalVariables.timerFloat < PlayerPrefs.GetFloat("l1hs")){
            PlayerPrefs.SetFloat("l1hs", globalVariables.timerFloat);
        }
        }
        else{
            PlayerPrefs.SetFloat("l1hs", globalVariables.timerFloat);
        }
        if (PlayerPrefs.GetInt("currentlevel") == 1){
            PlayerPrefs.SetInt("currentlevel", 2);
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
