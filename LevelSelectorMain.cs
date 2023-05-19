using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectorMain : MonoBehaviour
{
    [SerializeField] int buildNumber;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OpenScene(){
        SceneManager.LoadScene(buildNumber);
    }
    public void loadInstructions(){
        SceneManager.LoadScene(4);
    }
    public void loadmainMenu(){
        SceneManager.LoadScene(0);
    }

}
