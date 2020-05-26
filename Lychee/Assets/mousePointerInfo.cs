using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousePointerInfo : MonoBehaviour
{
    [SerializeField]
    private string selectableTag = "Selectable";
    Vector3 pointerPosition = -Vector3.one;
    
    void FixedUpdate()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            if(selection.CompareTag(selectableTag))
            {
                pointerPosition = hit.point;
                Debug.Log(pointerPosition);   
            }
        }   
    }
}
