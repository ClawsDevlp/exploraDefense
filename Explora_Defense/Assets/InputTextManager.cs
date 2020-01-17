using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UIHandler;

public class InputTextManager : MonoBehaviour
{
    public InputField newCode;
    public void Text_Changed( Image newPage)
    {
        float temp = float.Parse(newCode.text);
        if(temp == 1234)
        {
            GetComponent<UIHandler>().navStart(newPage);
            //navStart();
            Debug.Log("Hello World"); 
        } else {
            Debug.Log("NUL World"); 
        }
    }
}
