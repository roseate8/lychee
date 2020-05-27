using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Subdiv.Demo
{

    [RequireComponent (typeof(MeshFilter))]
    public class GPUSubdivTest : MonoBehaviour {

        [SerializeField] protected ComputeShader subdivCompute;
        [SerializeField, Range(1, 4)] protected int details = 1;
        [SerializeField] bool weld = false;
        MeshFilter filter;
        Mesh source;
        public Slider subdivisionLevel;
        // public Text myText;
        [SerializeField] TextMeshProUGUI m_Object;
        public Button yourButton;

		void Start()
        {
            filter = GetComponent<MeshFilter>();
            source = filter.mesh;
            // StartSubdivion();
            yourButton.onClick.AddListener(StartSubdivion);
        }        
        void Update() {
            m_Object.text = "Subdivison Level: " + Mathf.Floor(subdivisionLevel.value);
            details = (int)subdivisionLevel.value;
            // StartSubn.onClick.AddListener(StartSubdivion);
        }
        public void StartSubdivion()
        {
            var mesh = GPUSubdivisionSurface.Subdivide(subdivCompute, SubdivisionSurface.Weld(source, float.Epsilon, source.bounds.size.x), details, weld);
            filter.sharedMesh = mesh;
        }
    }

}


