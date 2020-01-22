using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class validateCheckHandler : MonoBehaviour
{
    public void validateCheck(Image newPage){
        if(GetComponent<checkHandler>().goodCheck == 5 && GetComponent<checkHandler>().countCheck == 5)
        {
            GetComponent<UIHandler>().changePage(newPage);
        } else {
            GetComponent<UIHandler>().showError();
        }
    }
}
