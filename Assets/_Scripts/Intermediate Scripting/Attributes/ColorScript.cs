using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ColorScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GetComponent<Renderer>().sharedMaterial.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
