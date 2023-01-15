using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IBeginDragHandler, IDragHandler
{
    [SerializeField] Transform main;
    [SerializeField] float speed;
    private float startPoint;
    public void OnBeginDrag(PointerEventData eventData)
    {
        startPoint = eventData.position.x;
    }

    public void OnDrag(PointerEventData eventData)
    {
        var rotation = main.rotation;
        var current = rotation.eulerAngles.y;
        current -= eventData.delta.x * speed;
        rotation.eulerAngles = new Vector3(0, current, 0);
        main.rotation= rotation;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
       
    }

   
}
