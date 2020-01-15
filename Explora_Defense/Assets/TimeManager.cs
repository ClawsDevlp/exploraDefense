using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public float startingTime;
    private Text theText;
    void Start()
    {
        theText = GetComponent<Text>();
        startingTime *= 60;
    }

    // Update is called once per frame
    void Update()
    {
        startingTime = startingTime - Time.deltaTime;
        theText.text = "" + Mathf.Round(startingTime/60) + " min " + Mathf.Round(startingTime/3);
    }
}
