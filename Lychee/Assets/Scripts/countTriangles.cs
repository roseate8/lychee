using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class countTriangles : MonoBehaviour
{
    private int vertexCount;
    private int submeshCount;
    private int triangleCount;
    private int vcount;
    private int subcount;
    private int tcount;
    [SerializeField]
    private GameObject obj;

    // [MenuItem ("Tools/Mesh Info")]
    // static void Init ()
    // {
    //     // Get existing open window or if none, make a new one:
    //     countTriangles window = (countTriangles)EditorWindow.GetWindow(typeof(countTriangles));
    //     window.titleContent.text = "Mesh Info";
    // }

    // void OnSelectionChange()
    // {
    //     Repaint();
    // }
    void Start()
    {
        vcount = obj.GetComponent<MeshFilter>().sharedMesh.vertexCount;
        tcount = obj.GetComponent<MeshFilter>().sharedMesh.triangles.Length/3;
        subcount = obj.GetComponent<MeshFilter>().sharedMesh.subMeshCount;
        Debug.Log("Vertices: " + vcount);
        Debug.Log("Triangles: " + tcount);
        Debug.Log("Submeshes: " + subcount);
    }



    void OnGUI()
    {
        if(Selection.activeGameObject && Selection.activeGameObject.GetComponent<MeshFilter>())
        {

            vertexCount = Selection.activeGameObject.GetComponent<MeshFilter>().sharedMesh.vertexCount;
            triangleCount = Selection.activeGameObject.GetComponent<MeshFilter>().sharedMesh.triangles.Length/3;
            submeshCount = Selection.activeGameObject.GetComponent<MeshFilter>().sharedMesh.subMeshCount;

            EditorGUILayout.LabelField(Selection.activeGameObject.name);
            EditorGUILayout.LabelField("Vertices: ", vertexCount.ToString());
            EditorGUILayout.LabelField("Triangles: ", triangleCount.ToString());
            EditorGUILayout.LabelField("SubMeshes: ", submeshCount.ToString());
        }
    }
}
