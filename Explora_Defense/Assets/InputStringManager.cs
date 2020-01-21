using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputStringManager : MonoBehaviour
{
    public InputField newCode;
    public string code;

    public void Text_Changed(Image newPage)
    {
        string temp = newCode.text;
        if(code.CompareTo(temp) == 0)
        {
            GetComponent<UIHandler>().changePage(newPage);
        } else {
            // Faire message erreur utilisateur
            Debug.Log("NUL World"); 
        }
    }
   
}
