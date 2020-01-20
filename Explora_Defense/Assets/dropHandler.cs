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
    public void OnDrop(PointerEventData eventData)
    {
        RectTransform invPanel = transform as RectTransform;

        if(!RectTransformUtility.RectangleContainsScreenPoint(invPanel, Input.mousePosition))
        {
            Debug.Log("drop item");
        }
    }
}
