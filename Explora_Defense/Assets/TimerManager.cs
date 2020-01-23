using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text timerHours;
    public Text timerMinutes;
    public Text timerSeconds;

   
    public float startTime;
    private float stopTime;
    private float timerTime;
    private bool isRunning = false;

    void Start()
    {
        TimerReset();
        TimerStop();
    }
 
    public void TimerStart()
    {
    
        if(!isRunning)
        {
            isRunning = true;
            startTime *=3600;
        }
    }
    public void TimerReset()
    {
        timerHours.text = timerMinutes.text = timerSeconds.text = "00";    

    }
    public void TimerStop()
    {
        if(isRunning)
        {
            isRunning = false;
            stopTime = Time.deltaTime;
        }
    }

    // Update is called once per frame
    void Update()
    {
        timerTime = stopTime + ( startTime - Time.deltaTime );
        int seconds = (int)(timerTime %60);
        int minutes = (int)(timerTime / 60) % 60;
        int hours = (int)(timerTime/3600) %24;

        if(isRunning)
        {
            timerHours.text = hours.ToString();
            timerMinutes.text = minutes.ToString();
            timerSeconds.text = seconds.ToString();
            startTime -= Time.deltaTime;
        }
    }
}
