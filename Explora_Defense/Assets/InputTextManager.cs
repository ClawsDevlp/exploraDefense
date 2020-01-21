using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UIHandler;

public class InputTextManager : MonoBehaviour
{
    public InputField newCode;
    public int code;

    public void Text_Changed(Image newPage)
    {
        float temp = float.Parse(newCode.text);
        if(temp == code)
        {
            GetComponent<UIHandler>().changePage(newPage);
        } else {
            // Faire message erreur utilisateur
            Debug.Log("NUL World"); 
        }
    }
}
