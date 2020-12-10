using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject Cube;
    public bool Switch = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Switch = !Switch;
        }
        if (Switch)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Destroy(Cube);
            }
            else if (Input.GetKeyDown(KeyCode.I))
            {
                Cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                Cube.SetActive(false);
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                Cube.SetActive(true);
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Destroy(Cube.GetComponent<MeshRenderer>());
            }
            else if (Input.GetKeyDown(KeyCode.I)){
                MeshRenderer mesh = Cube.AddComponent<MeshRenderer>();
                GameObject primitive = GameObject.CreatePrimitive(PrimitiveType.Cube);
                Material material = primitive.GetComponent<MeshRenderer>().sharedMaterial;
                Destroy(primitive);
                mesh.sharedMaterial = material;
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                Cube.GetComponent<MeshRenderer>().enabled = false;
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                Cube.GetComponent<MeshRenderer>().enabled = true;
            }
        }
    }
}
