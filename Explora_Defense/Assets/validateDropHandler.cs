using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class validateDropHandler : MonoBehaviour
{
    public dropHandler elmtTete;
    public dropHandler elmtCoeur;
    public dropHandler elmtMain;
    public dropHandler elmtPied;

    public void validateDrop(Image newPage){
        elmtCoeur.checkGoodDrop();
        elmtTete.checkGoodDrop();
        elmtMain.checkGoodDrop();
        elmtPied.checkGoodDrop();

        if(elmtTete.goodDrop == true && elmtCoeur.goodDrop == true && elmtPied.goodDrop == true && elmtMain.goodDrop == true)
        {
            GetComponent<UIHandler>().changePage(newPage);
        } else {
            GetComponent<UIHandler>().showError();
        }
    }
}
