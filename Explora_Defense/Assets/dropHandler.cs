using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dropHandler : MonoBehaviour, IDropHandler
{
    /*public GameObject item {
        get {
            if(transform.childCount>0)
            {
                return transform.getChild(0);
            }
            return null;
        }
    }*/
    
    private RectTransform rectTransform;

    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null)
        {
            rectTransform = eventData.pointerDrag.GetComponent<RectTransform>();
            
            if(GetComponent<RectTransform>() != null){
                rectTransform.position = GetComponent<RectTransform>().position;
                rectTransform.SetParent(GetComponent<RectTransform>());
                Debug.Log("Pointage");
            } else {
                rectTransform.position = Vector3.zero;
                Debug.Log("NAAAAAAH");
            }
        }
    }
}
