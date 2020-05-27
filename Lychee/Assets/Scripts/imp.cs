using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;


public class imp : MonoBehaviour
{
    public Shader flatWireframe;
    public string modelPath = "E:/Downloads/card.obj";
	public Material wireframe;
    public MeshFilter filter;
//  This script imports a new model in .obj format
//  enter the path for the object in the holdermesh variable

    void Start()
    {
        // Debug.Log(Directory.Exists(modelPath));

        Mesh holderMesh = new Mesh();
        ObjImporter newMesh = new ObjImporter();
        holderMesh = newMesh.ImportFile(modelPath);

        //add mesh collider to the new imported object and bake it according to its mesh

        MeshCollider colliderMesh = gameObject.AddComponent<MeshCollider>();
        colliderMesh.convex = true;
        colliderMesh.sharedMesh = holderMesh;

        // capsule collider
        // CapsuleCollider colliderMesh = gameObject.AddComponent<CapsuleCollider>();
        
        //adding a wireframe renderer

        MeshRenderer renderer = gameObject.AddComponent<MeshRenderer>();
        filter = gameObject.AddComponent<MeshFilter>();
        Material wireframe = new Material(flatWireframe);
        filter.mesh = holderMesh;
        Renderer rend = GetComponent<Renderer>();
        if (rend != null){
            rend.material = wireframe;
        }

        //aligning the camera to fit the screen

        // Vector3 xyz = filter.GetComponent<MeshFilter>().mesh.bounds.size;
        // float distance = Mathf.Max(xyz.x, xyz.y, xyz.z);
        // distance /= (2.0f * Mathf.Tan(0.5f * mainCam.fieldOfView * Mathf.Deg2Rad));
        // // Move camera in -z-direction; change '2.0f' to your needs
        // mainCam.transform.position = new Vector3(mainCam.transform.position.x, mainCam.transform.position.y, -distance * 2.0f);

    }
}