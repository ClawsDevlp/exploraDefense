using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    public void changePage(Image page)
    {
        if(!page.gameObject.activeSelf)
        {
            page.gameObject.SetActive(true);
        }
        else
        {
            page.gameObject.SetActive(false);
        }
    }

    public Text textError;

  
     
    public void showError(){
        textError.gameObject.SetActive(true);
        
        
    }
}
