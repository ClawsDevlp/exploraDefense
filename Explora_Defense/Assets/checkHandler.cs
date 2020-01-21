using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class checkHandler : MonoBehaviour
{
    public Sprite notCheck;
    public Sprite check;
    public Button diff1;
    public int countCheck;
    public int goodCheck;

    public void isCheck(Button btn)
    {
        if(btn.image.overrideSprite == notCheck)
        {
            btn.image.overrideSprite = check;
            countCheck++;
            if(btn == diff1)
            {
                goodCheck++;
            }
        } else {
            btn.image.overrideSprite = notCheck;
            countCheck--;
            if(btn == diff1)
            {
                goodCheck--;
            }
        }
    }
}
