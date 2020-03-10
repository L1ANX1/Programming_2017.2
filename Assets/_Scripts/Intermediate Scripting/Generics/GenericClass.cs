using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Here is a generic clas. Notice the generic type 'T'.
// 'T' will be replaced with an actual type, as will be instance of the type 'T' used in class.
public class GenericClass<T>
{
    T item;
    public void UpdateItem(T newItem)
    {
        item = newItem;
    }
}
