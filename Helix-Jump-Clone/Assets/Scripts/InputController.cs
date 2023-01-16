using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputController : MonoBehaviour, IDragHandler
{
    [SerializeField] Transform main;
    [SerializeField] float speed;   
    public void OnDrag(PointerEventData eventData)
    {
        var rotation = main.rotation;
        var current = rotation.eulerAngles.y;
        current -= eventData.delta.x * speed;
        rotation.eulerAngles = new Vector3(0, current, 0);
        main.rotation= rotation;
    }   
}
