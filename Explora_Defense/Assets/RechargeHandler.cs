using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RechargeHandler : MonoBehaviour
{
    public InputField codePage;

    public Image tourEgeePage;
    public Image icarePage;
    public Image archePage;
    public Image signauxLumPage;
    public Image pontJaponaisPage;
    public Image araigneePage;
   // public Image fontaineArcCielPage;
    public Image statueDefensePage;
    public Image chemineeVegePage;
    public Image MorsePage;
    public Image fontaineCorollePage;
    public Image enigmeEauPage;
    public Image terrePage;
    public Image troisArbresPage;
    public Image morettiPage;
    public Image hommesCitePage;
    public Image bancPublicPage;
    

    public void checkCode()
    {
        float temp = float.Parse(codePage.text);

        switch (temp)
        {
            case 0302:
                GetComponent<UIHandler>().changePage(tourEgeePage);
                break;
            case 1504:
                GetComponent<UIHandler>().changePage(icarePage);
                break;
            case 0806:
                GetComponent<UIHandler>().changePage(archePage);
                break;
            case 0404:
                GetComponent<UIHandler>().changePage(signauxLumPage);
                break;
            case 1608:
                GetComponent<UIHandler>().changePage(pontJaponaisPage);
                break;
            case 0912:
                GetComponent<UIHandler>().changePage(araigneePage);
                break;
            /*case 0902:
                GetComponent<UIHandler>().changePage(fontaineArcCielPage);
                break;*/
            case 0508:
                GetComponent<UIHandler>().changePage(statueDefensePage);
                break;
            case 1716:
                GetComponent<UIHandler>().changePage(chemineeVegePage);
                break;
            case 1024:
                GetComponent<UIHandler>().changePage(MorsePage);
                break;
            case 0616:
                GetComponent<UIHandler>().changePage(fontaineCorollePage);
                break;
            case 1832:
                GetComponent<UIHandler>().changePage(enigmeEauPage);
                break;
            case 1148:
                GetComponent<UIHandler>().changePage(terrePage);
                break;
            case 0732:
                GetComponent<UIHandler>().changePage(troisArbresPage);
                break;
            case 1964:
                GetComponent<UIHandler>().changePage(morettiPage);
                break;
            case 1296:
                GetComponent<UIHandler>().changePage(hommesCitePage);
                break;
            case 0864:
                GetComponent<UIHandler>().changePage(bancPublicPage);
                break;
            default:
                GetComponent<UIHandler>().showError();
                break;
        }
    }
}
