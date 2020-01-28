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
    public int type = 0;
    public int timer = 0;
    private int finishPenality = 0;

    private int seconds;
    private int minutes;
    private int hours;
    public float startTime;
    private float stopTime;
    private float timerTime;
    private bool isRunning = false;

    public Button penalitybutton;

    void Start()
    {
        TimerReset();
        TimerStop();
    }
 
    public void TimerStart()
    {
        
        if(!isRunning )
        {
            isRunning = true;
            if(type ==0 )
            {
                startTime *=3600;
            }
            else{
                //startTime *=60;
                
                startTime = timer;
                penality = 1;
            }
        }

    }


    public void penalityTime()
    {
        TimerStart();   
        
        if(penality == 0)
        {
           penalitybutton.gameObject.SetActive(true); 
           timerHours.gameObject.SetActive(false);
           timerMinutes.gameObject.SetActive(false);
           timerSeconds.gameObject.SetActive(false);
           TimerStop();
           finishPenality = 0;
        }
        else
        {
            finishPenality =1;
            timerHours.gameObject.SetActive(true);
           timerMinutes.gameObject.SetActive(true);
           timerSeconds.gameObject.SetActive(true);
            penalitybutton.gameObject.SetActive(false);
        }
        Debug.Log(penality);
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
        timerTime = stopTime + ( startTime - Time.deltaTime);
        seconds = (int)(timerTime %60);
        minutes = (int)(timerTime / 60) % 60;
        hours = (int)(timerTime/3600) %24;

        /*
        if(penality != 0)
        {
            penalityTime =  10 * 3600;
            //minutes -= 10;
            Debug.Log(minutes);
            penalityTime =0;
        }*/
        if( seconds == 0 && minutes == 0 && finishPenality == 1)
        {
            Debug.Log( "penality terminé");
            penality = 0;
            penalityTime();
            //GetComponent<InputTextManager>().error = 0;
        }
        else
        {
            penality = 1;
            //GetComponent<InputTextManager>().error = 1;
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
