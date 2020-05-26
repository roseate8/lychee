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

        //adding a wireframe renderer

        MeshRenderer renderer = gameObject.AddComponent<MeshRenderer>();
        MeshFilter filter = gameObject.AddComponent<MeshFilter>();
        Material wireframe = new Material(flatWireframe);
        filter.mesh = holderMesh;
        Renderer rend = GetComponent<Renderer>();
        if (rend != null){
            rend.material = wireframe;
        }
    }
}