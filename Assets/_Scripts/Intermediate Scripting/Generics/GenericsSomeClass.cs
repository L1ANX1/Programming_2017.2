using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsSomeClass
{
    //Generics 通用/泛型
    // Here is a generic method. Notice the generic type 'T'.
    // This 'T' will be replaced at runtime with an actual type.
    public T GenericMethod<T>(T param)
    {
        Debug.Log("GenericsSomeClass T: " + param);
        return param;
    }
}
