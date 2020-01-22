using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class checkHandler : MonoBehaviour
{
    public Sprite notCheck;
    public Sprite check;
    public int countCheck;
    public int goodCheck;
    
    public Button diff1;
    public Button diff2;
    public Button diff3;
    public Button diff4;
    public Button diff5;

    public void isCheck(Button btn)
    {
        if(btn.image.overrideSprite == notCheck)
        {
            btn.image.overrideSprite = check;
            countCheck++;
            if(btn == diff1 || btn == diff2 || btn == diff3 || btn == diff4 || btn == diff5)
            {
                goodCheck++;
            }
        } else {
            btn.image.overrideSprite = notCheck;
            countCheck--;
            if(btn == diff1 || btn == diff2 || btn == diff3 || btn == diff4 || btn == diff5)
            {
                goodCheck--;
            }
        }
    }
}
