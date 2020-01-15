using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    public GameObject img;
    public Image nav;
    public Image oui;
    public Image non;
    
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
        if(!nav.gameObject.active)
        {
            nav.gameObject.SetActive(true);     
            //nav.fillAmount = 1.0f;
            StartCoroutine(startSlide(1.0f));
        }
        else if(nav.gameObject.active)
        {    
            //nav.fillAmount = 1.0f;
            StartCoroutine(startSlide(-1.0f));
        }
        
    }

    IEnumerator startSlide(float i)
    {
        yield return new WaitForSeconds(0.0001f);
        nav.fillAmount = nav.fillAmount + i; 
        oui.fillAmount = oui.fillAmount + i;
        non.fillAmount = non.fillAmount + i;
        //Debug.Log("Test 123");
        if(nav.fillAmount < 1 && nav.fillAmount > 0 )
            StartCoroutine(startSlide(i));
        else if( nav.fillAmount == 0)
        {
            nav.gameObject.SetActive(false);
        }
            
    }
    
}
