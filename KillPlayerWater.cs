using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayerWater : MonoBehaviour
{
    [SerializeField] GameOverScreen gameoverscreen;
    void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
            gameoverscreen.Setup();
            PlayerPrefs.SetFloat("currentscore", globalVariables.timerFloat);
        }
    }
}
