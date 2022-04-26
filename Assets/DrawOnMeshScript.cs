using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawOnMeshScript : MonoBehaviour
{
    [SerializeField]
    private GameObject eraserGameObject;

    private Material mainMat;

    private void Start()
    {
        mainMat = GetComponent<MeshRenderer>().material;
    }

    private void Update()
    {
        eraserGameObject.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.forward * 10);
        if (Input.GetMouseButton(0))
        {
            mainMat.SetVector("_EraserPos", Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.forward * 10));
        }
    }
}
