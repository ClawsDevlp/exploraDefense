using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    public GameObject img;
    public Image nav;
    
    public void buttonEvent()
    {
        if(img.active)
        {
            img.SetActive(false);
            
        }
        else
        {
            img.SetActive(true);
        }
        
        //img2.SetActive(true);
        //Debug.Log("Hello World"); 
    }
    
    
    
     public void navStart()
    {
        nav.gameObject.SetActive(true);     
        nav.fillAmount = 1.0f;
    }
    
}
