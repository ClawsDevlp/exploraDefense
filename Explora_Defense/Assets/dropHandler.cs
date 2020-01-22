using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class dropHandler : MonoBehaviour, IDropHandler
{
    private RectTransform element;
    public RectTransform rightElement;
    public bool goodDrop = false;

    public void OnDrop(PointerEventData eventData)
    {
        element = eventData.pointerDrag.GetComponent<RectTransform>();

        if(transform.childCount > 0)
        {
            transform.GetChild(0).SetParent(element.parent);
        }

        if(eventData.pointerDrag != null)
        {
            element.SetParent(transform);
        }
    }

    public void checkGoodDrop(){
        if(transform.childCount > 0)
        {
            if(transform.GetChild(0) == rightElement)
            {
                goodDrop = true;
            } else {
                goodDrop = false;
            }
        }
    }
}
