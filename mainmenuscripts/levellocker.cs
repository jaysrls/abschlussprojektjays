using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levellocker : MonoBehaviour
{
    public Button[] lvlButtons;
    void Start()
    {
        if (PlayerPrefs.HasKey("currentlevel")){
        }
        else{
            PlayerPrefs.SetInt("currentlevel",1);
        }
        for (int i = 0; i < lvlButtons.Length; i++){
            if(PlayerPrefs.GetInt("currentlevel") < i+1){
                lvlButtons[i].interactable = false;
            }
            else{
                lvlButtons[i].interactable = true;
            }
        }
    }
 
    void Update()
    {

    }
}
