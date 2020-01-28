using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public float startingTime = 2.0f;
    private Text theText;
    
    void Start()
    {
        theText = GetComponent<Text>();
        startingTime *= 60;
    }


    // Update is called once per frame
    void Update()
    {
        int seconds = (int)(startingTime %60);
        int minutes = (int)(startingTime / 60) % 60;
        int hours = (int)(startingTime/3600) %24;
        startingTime = startingTime - Time.deltaTime;
        theText.text = "" + Mathf.Round(hours) + " : " + Mathf.Round(minutes) + " : " + Mathf.Round(seconds);
    }
}
