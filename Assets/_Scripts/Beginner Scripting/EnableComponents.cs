using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableComponents : MonoBehaviour {
    // Enabling and Disabling Components
    private Light myLight;

    // Use this for initialization
    void Start () {
        myLight = GetComponent<Light> ();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown (KeyCode.Space))
            myLight.enabled = !myLight.enabled;

    }
}