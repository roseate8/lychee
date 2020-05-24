using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class imp : MonoBehaviour
{
    public Shader flatWireframe;
	public Material wireframe;
   // Use this for initialization
    void Start()
    {
        Mesh holderMesh = new Mesh();
        ObjImporter newMesh = new ObjImporter();
        holderMesh = newMesh.ImportFile("E:/Downloads/card.obj");

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