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

    // Functions only used to begin the game
    public Image barAvancement;

    public void beginGame(Image page)
    {
        page.gameObject.SetActive(true);
        if(barAvancement)
        {
            showBarAvancement(barAvancement);
        }
    }

    public void showBarAvancement(Image bar)
    {
        bar.gameObject.SetActive(true);
    }

    public void changeToRechargePage(Image page)
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
    
}
