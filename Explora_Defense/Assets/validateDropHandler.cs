using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class validateDropHandler : MonoBehaviour
{
    public dropHandler elmtRightWing;
    public dropHandler elmtLeftWing;
    public dropHandler elmtLeftThigh;
    public dropHandler elmtPubis;
    public dropHandler elmtLeftFoot;
    public dropHandler elmtRightBelly;

    public void validateDrop(Image newPage){
        elmtRightWing.checkGoodDrop();
        elmtLeftWing.checkGoodDrop();
        elmtLeftThigh.checkGoodDrop();
        elmtPubis.checkGoodDrop();
        elmtLeftFoot.checkGoodDrop();
        elmtRightBelly.checkGoodDrop();

        if(elmtRightWing.goodDrop == true && elmtLeftWing.goodDrop == true && elmtLeftThigh.goodDrop == true && elmtPubis.goodDrop == true && elmtLeftFoot.goodDrop == true && elmtRightBelly.goodDrop == true)
        {
            GetComponent<UIHandler>().changePage(newPage);
        } else {
            GetComponent<UIHandler>().showError();
        }
    }
}
