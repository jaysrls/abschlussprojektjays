using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] int respawn;
    [SerializeField] Rigidbody2D rb;
    public void Setup(){
        gameObject.SetActive(true);
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
    }
    public void restartButton(){
        SceneManager.LoadScene(respawn);
    }
    public void mainMenuButton(){
        SceneManager.LoadScene(0);
    }
}
