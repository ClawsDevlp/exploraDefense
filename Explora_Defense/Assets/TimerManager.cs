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

    public int penality = 0;

    private int seconds;
    private int minutes;
    private int hours;
    public float startTime;
    private float stopTime;
    private float penalityTime;
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

    public void TimerPenality()
    {
        //Debug.Log(GetComponent<UIHandler>().error);

        penality = 1;
       
    }

    // Update is called once per frame
    void Update()
    {
        timerTime = stopTime + ( startTime - Time.deltaTime - penalityTime );
        seconds = (int)(timerTime %60);
        minutes = (int)(timerTime / 60) % 60;
        hours = (int)(timerTime/3600) %24;

        if(penality != 0)
        {
            penalityTime =  10 * 3600;
            //minutes -= 10;
            Debug.Log(minutes);
            penalityTime =0;
        }
      
        if(isRunning)
        {
            timerHours.text = hours.ToString();
            timerMinutes.text = minutes.ToString();
            timerSeconds.text = seconds.ToString();
            startTime -= Time.deltaTime;
        }
    }
}
