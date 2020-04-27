using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    private GameObject avancementFill;
    private float lengthX = 0.00338f;

    public void changePage(Image page)
    {
        avancementFill = GameObject.Find("AvancementFill");
        if(!page.gameObject.activeSelf)
        {
            page.gameObject.SetActive(true);
            avancementFill.transform.localScale += new Vector3(lengthX, 0, 0);
        }
        else
        {
            page.gameObject.SetActive(false);
            avancementFill.transform.localScale -= new Vector3(lengthX, 0, 0);
        }
    }

    public Text textError;

    
    public void showError(){
        textError.gameObject.SetActive(true);
    }
    
}
