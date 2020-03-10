using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        SomeClass myClass = new SomeClass();

        // The specific Add method called will depend on the arguments passed in.
        Debug.Log(myClass.Add(1, 2));
        Debug.Log(myClass.Add("Hello", "world"));
    }

}
