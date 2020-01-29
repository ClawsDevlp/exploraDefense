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
            case 0404:
                GetComponent<UIHandler>().changePage(icarePage);
                break;
            case 0508:
                GetComponent<UIHandler>().changePage(archePage);
                break;
            case 0616:
                GetComponent<UIHandler>().changePage(signauxLumPage);
                break;
            case 0732:
                GetComponent<UIHandler>().changePage(pontJaponaisPage);
                break;
            case 0864:
                GetComponent<UIHandler>().changePage(araigneePage);
                break;
            /*case 0902:
                GetComponent<UIHandler>().changePage(fontaineArcCielPage);
                break;*/
            case 1004:
                GetComponent<UIHandler>().changePage(statueDefensePage);
                break;
            case 1108:
                GetComponent<UIHandler>().changePage(chemineeVegePage);
                break;
            case 1216:
                GetComponent<UIHandler>().changePage(MorsePage);
                break;
            case 1332:
                GetComponent<UIHandler>().changePage(fontaineCorollePage);
                break;
            case 1464:
                GetComponent<UIHandler>().changePage(enigmeEauPage);
                break;
            case 1502:
                GetComponent<UIHandler>().changePage(terrePage);
                break;
            case 1604:
                GetComponent<UIHandler>().changePage(troisArbresPage);
                break;
            case 1708:
                GetComponent<UIHandler>().changePage(morettiPage);
                break;
            case 1816:
                GetComponent<UIHandler>().changePage(hommesCitePage);
                break;
            case 1932:
                GetComponent<UIHandler>().changePage(bancPublicPage);
                break;
        }
    }
}
