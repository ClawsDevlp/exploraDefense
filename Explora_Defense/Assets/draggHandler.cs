using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class draggHandler : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler//, IDropHandler
{
    Transform startParent;
    Vector3 startPosition;

    public void OnBeginDrag(PointerEventData eventData)
    {
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        startParent = transform.parent;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }
    
    public void OnEndDrag(PointerEventData eventData)
    {
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        if(transform.parent == startParent){
			transform.position = transform.parent.position;
		}
    }
}
