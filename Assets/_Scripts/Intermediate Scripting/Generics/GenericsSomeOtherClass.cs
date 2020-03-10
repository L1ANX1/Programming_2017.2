using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsSomeOtherClass : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        GenericsSomeClass myClass = new GenericsSomeClass();

        // In order to use this method you must tell the method what type to replace 'T' with
        myClass.GenericMethod<int>(5);
    }

}
