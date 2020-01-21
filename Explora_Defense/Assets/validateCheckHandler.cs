using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class validateCheckHandler : MonoBehaviour
{
    public void validateCheck(Image newPage){
        //Debug.Log(GetComponent<checkHandler>().goodCheck); 
        if(GetComponent<checkHandler>().goodCheck == 1 && GetComponent<checkHandler>().countCheck == 1)
        {
            GetComponent<UIHandler>().changePage(newPage);
        } else {
            Debug.Log("Vous n'avez pas trouvé les différences");
        }
    }
}
