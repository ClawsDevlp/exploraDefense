using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    //public GameObject img;
    //public Image nav;
    //public Image oui;
    //public Image non;
    
    /*
    public void buttonEvent()
    {
        if(img.activeSelf)
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
    
    */
    
     public void navStart(Image nov)
    {
        if(!nov.gameObject.activeSelf)
        {
            nov.gameObject.SetActive(true);    
            nov.fillAmount = 1.0f;
            Debug.Log("active"); 
            //StartCoroutine(startSlide(1.0f));
        }
        else if(nov.gameObject.activeSelf)
        {
            nov.gameObject.SetActive(false);    
            nov.fillAmount = 0.0f;
            Debug.Log("desactive");
            //StartCoroutine(startSlide(-1.0f));
        }
        
    }
    /*
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

    */
    
}
