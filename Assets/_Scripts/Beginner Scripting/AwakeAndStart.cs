using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStart : MonoBehaviour
{
    // Awake and Start

    void Awake()
    {
        // Reference between scripts, initialization
        // eg. Set Ammo for the enemy
        Debug.Log("Awake called.");
    }
    // Use this for initialization
    void Start()
    {
        // Once script component is enabled
        // eg. Allow enemy to shoot
        Debug.Log("Start called.");
    }

}