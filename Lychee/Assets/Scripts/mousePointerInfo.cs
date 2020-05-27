using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    
    // // Draw red a rombus on the screen
    // // and also draw a small cyan Quad in the left corner
    // [SerializeField] Material mat;
    // void OnPostRender()
    // {
    //     if (!mat)
    //     {
    //         Debug.LogError("Please Assign a material on the inspector");
    //         return;
    //     }

    //     GL.PushMatrix();
    //     mat.SetPass(0);
    //     // GL.LoadOrtho(); 
        
    //     GL.LoadIdentity();
    //     GL.MultMatrix(Matrix4x4.identity);

    //     GL.Begin(GL.QUADS);
    //     GL.Color(Color.red);
    //     GL.Vertex3(pointerPosition.x + 0, pointerPosition.y + 0.5f, 0);
    //     GL.Vertex3(pointerPosition.x + 0.5f, pointerPosition.y + 1, 0);
    //     GL.Vertex3(pointerPosition.x + 1, pointerPosition.y + 0.5f, 0);
    //     GL.Vertex3(pointerPosition.x + 0.5f, pointerPosition.y + 0, 0);

    //     GL.Color(Color.cyan);
    //     GL.Vertex3(pointerPosition.x + 0, pointerPosition.y + 0, 0);
    //     GL.Vertex3(pointerPosition.x + 0, pointerPosition.y + 0.25f, 0);
    //     GL.Vertex3(pointerPosition.x + 0.25f, pointerPosition.y + 0.25f, 0);
    //     GL.Vertex3(pointerPosition.x + 0.25f, pointerPosition.y + 0, 0);
    //     GL.End();
    //     GL.PopMatrix();
    // }
}
