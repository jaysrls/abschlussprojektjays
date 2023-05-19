using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class globalVariables : MonoBehaviour
{
    [SerializeField] Text timerText;
    [SerializeField] Text itemsCollectedText;
    public static float timerFloat;
    public static int itemsCollected;
    [SerializeField] int maxItems;
    
    void Start()
    {
        timerFloat = 0;
    }

    // Update is called once per frame
    void Update()
    {
        itemsCollectedText.text = globalVariables.itemsCollected.ToString() + "/" + maxItems.ToString();
        timerFloat += Time.deltaTime;
        timerText.text = timerFloat.ToString("0.0");
    }
}
