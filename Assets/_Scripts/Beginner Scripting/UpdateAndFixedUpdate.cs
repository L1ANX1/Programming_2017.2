using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    // Update and FixedUpdate

    void FixedUpdate()
    {
        // Called every physics step
        // FixedUpdate intervals are consistent
        // Use for regular update such as:
        // Adjusting physics(Rigidbody) objects

        Debug.Log("FixedUpdate time : " + Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        // Called every frame
        // Used for regular updates such as:
        // Moving non-Physics objects
        // Simple Timers
        // Receiving Input

        // Update interval times vary
        Debug.Log("Update time : " + Time.deltaTime);
    }
}