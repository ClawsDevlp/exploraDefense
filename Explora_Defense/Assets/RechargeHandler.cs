using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RechargeHandler : MonoBehaviour
{
    public InputField codePage;
    public GameObject avancementFill;
    public Image barAvancement;

    public Image tourEgeePage;
    public Image icarePage;
    public Image archePage;
    public Image signauxLumPage;
    public Image pontJaponaisPage;
    public Image araigneePage;
    public Image statueDefensePage;
    public Image chemineeVegePage;
    public Image MorsePage;
    public Image fontaineCorollePage;
    public Image enigmeEauPage;
    public Image terrePage;
    public Image troisArbresPage;
    public Image hommesCitePage;
    public Image bancPublicPage;
    

    public void checkCode()
    {
        float temp = float.Parse(codePage.text);
        float lengthX = 0.00338f;
        avancementFill = GameObject.Find("AvancementFill");

        switch (temp)
        {
            case 0302:
                GetComponent<UIHandler>().beginGame(tourEgeePage);
                GetComponent<UIHandler>().showBarAvancement(barAvancement);
                avancementFill.transform.localScale += new Vector3(lengthX*5, 0, 0);
                break;
            case 1504:
                GetComponent<UIHandler>().beginGame(icarePage);
                GetComponent<UIHandler>().showBarAvancement(barAvancement);
                avancementFill.transform.localScale += new Vector3(lengthX*6, 0, 0);
                break;
            case 0806:
                GetComponent<UIHandler>().beginGame(archePage);
                GetComponent<UIHandler>().showBarAvancement(barAvancement);
                avancementFill.transform.localScale += new Vector3(lengthX*9, 0, 0);
                break;
/*  Pblm return
            case 0404:
                GetComponent<UIHandler>().beginGame(signauxLumPage);
                GetComponent<UIHandler>().showBarAvancement(barAvancement);
                avancementFill.transform.localScale += new Vector3(lengthX*11, 0, 0);
                break;
*/
            case 1608:
                GetComponent<UIHandler>().beginGame(pontJaponaisPage);
                GetComponent<UIHandler>().showBarAvancement(barAvancement);
                avancementFill.transform.localScale += new Vector3(lengthX*13, 0, 0);
                break;
            case 0912:
                GetComponent<UIHandler>().beginGame(araigneePage);
                GetComponent<UIHandler>().showBarAvancement(barAvancement);
                avancementFill.transform.localScale += new Vector3(lengthX*15, 0, 0);
                break;
            case 0508:
                GetComponent<UIHandler>().beginGame(statueDefensePage);
                GetComponent<UIHandler>().showBarAvancement(barAvancement);
                avancementFill.transform.localScale += new Vector3(lengthX*19, 0, 0);
                break;
            case 1716:
                GetComponent<UIHandler>().beginGame(chemineeVegePage);
                GetComponent<UIHandler>().showBarAvancement(barAvancement);
                avancementFill.transform.localScale += new Vector3(lengthX*20, 0, 0);
                break;
            case 1024:
                GetComponent<UIHandler>().beginGame(MorsePage);
                GetComponent<UIHandler>().showBarAvancement(barAvancement);
                avancementFill.transform.localScale += new Vector3(lengthX*22, 0, 0);
                break;
            case 0616:
                GetComponent<UIHandler>().beginGame(fontaineCorollePage);
                GetComponent<UIHandler>().showBarAvancement(barAvancement);
                avancementFill.transform.localScale += new Vector3(lengthX*23, 0, 0);
                break;
            case 1832:
                GetComponent<UIHandler>().beginGame(enigmeEauPage);
                GetComponent<UIHandler>().showBarAvancement(barAvancement);
                avancementFill.transform.localScale += new Vector3(lengthX*25, 0, 0);
                break;
            case 1148:
                GetComponent<UIHandler>().beginGame(terrePage);
                GetComponent<UIHandler>().showBarAvancement(barAvancement);
                avancementFill.transform.localScale += new Vector3(lengthX*26, 0, 0);
                break;
            case 0732:
                GetComponent<UIHandler>().beginGame(troisArbresPage);
                GetComponent<UIHandler>().showBarAvancement(barAvancement);
                avancementFill.transform.localScale += new Vector3(lengthX*28, 0, 0);
                break;
            case 1296:
                GetComponent<UIHandler>().beginGame(hommesCitePage);
                GetComponent<UIHandler>().showBarAvancement(barAvancement);
                avancementFill.transform.localScale += new Vector3(lengthX*33, 0, 0);
                break;
            case 0864:
                GetComponent<UIHandler>().beginGame(bancPublicPage);
                GetComponent<UIHandler>().showBarAvancement(barAvancement);
                avancementFill.transform.localScale += new Vector3(lengthX*34, 0, 0);
                break;
            default:
                GetComponent<UIHandler>().showError();
                break;
        }
    }
}
