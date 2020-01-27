using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputTextManager : MonoBehaviour
{
    public InputField newCode;
    public int code;
    public int error;

    public void Text_Changed(Image newPage)
    {
        float temp = float.Parse(newCode.text);
        if(temp == code)
        {
            GetComponent<UIHandler>().changePage(newPage);
        } else {
            GetComponent<UIHandler>().showError();
        }
    }
}
