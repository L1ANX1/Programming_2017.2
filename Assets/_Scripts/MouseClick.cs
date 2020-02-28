using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    Rigidbody rigidbody;
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        Debug.Log("debug ");
    }

    // Use this for initialization
    void Start()
    { }

    void OnMouseDown()
    {
        print("OnMouseDown");

        rigidbody.AddForce(-transform.forward * 500f);
        rigidbody.useGravity = true;
    }
}
