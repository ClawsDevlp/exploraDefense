using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputTextManager : MonoBehaviour
{
    public InputField newCode;
    public int code;

    public Button button;
    public int error;

    public void Text_Changed(Image newPage)
    {
        //error =  GetComponent<TimerManager>().penality;
        float temp = float.Parse(newCode.text);
        if(temp == code)
        {
            GetComponent<UIHandler>().changePage(newPage);
        } else {
            GetComponent<UIHandler>().showError();
            
            //GetComponent<TimerManager>().penalityTime(button);
            

        }
    }
}
