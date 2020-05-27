using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rescaleCamera : MonoBehaviour
{
    [SerializeField] Camera mainCam;
    imp importScript;
    // [SerializeField] private MeshFilter importedObject;
    // // Start is called before the first frame update
    // void Start()
    // {
       
    //     if(importScript.isImported)
    //     {
    //         // Vector3 xyz = importedObject.GetComponent<MeshFilter>().mesh.bounds.size;
    //         Vector3 xyz = importScript.filter.GetComponent<MeshFilter>().mesh.bounds.size;
    //         float distance = Mathf.Max(xyz.x, xyz.y, xyz.z);
    //         distance /= (2.0f * Mathf.Tan(0.5f * mainCam.fieldOfView * Mathf.Deg2Rad));
    //         // Move camera in -z-direction; change '2.0f' to your needs
    //         mainCam.transform.position = new Vector3(mainCam.transform.position.x, mainCam.transform.position.y, -distance * 2.0f);
    //         importScript.isImported = false;
    //     }
    // }

    // Update is called once per frame
    void Update()
    {
    }
}
