using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticsUtilitiesExample : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // You can access a static method by using the class name and the dot operator
        int x = StaticsUtilities.Add(5, 6);
        Debug.Log("Utilities Example add 5+6=" + x);
    }
}
