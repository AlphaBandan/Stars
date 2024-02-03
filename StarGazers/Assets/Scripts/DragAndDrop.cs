using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
   public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("BeginDrag");
    }

    public void OnDrag(PointerEventData eventData)

    {
        Debug.Log("onDrag");

    }
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("EndDrag");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("CLICK");
    }




}
