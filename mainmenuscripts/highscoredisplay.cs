using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscoredisplay : MonoBehaviour
{
    [SerializeField] Text l1hs;
    [SerializeField] Text l2hs;
    [SerializeField] Text l3hs;
    [SerializeField] Text lastscore;
    void Start()
    {
        lastscore.text = "your last run lasted " + PlayerPrefs.GetFloat("currentscore").ToString("0.0") + " seconds";
        if(PlayerPrefs.HasKey("l1hs")){
            l1hs.text = PlayerPrefs.GetFloat("l1hs").ToString("0.00") + " seconds";
        }
        else{
            l1hs.text = "not finished";
        }
        if(PlayerPrefs.HasKey("l2hs")){
            l2hs.text = PlayerPrefs.GetFloat("l2hs").ToString("0.00") + " seconds";
        }
        else{
             l2hs.text = "not finished";
        }
        if(PlayerPrefs.HasKey("l3hs")){
            l3hs.text = PlayerPrefs.GetFloat("l3hs").ToString("0.00") + " seconds";
        }
        else{
             l3hs.text = "not finished";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
