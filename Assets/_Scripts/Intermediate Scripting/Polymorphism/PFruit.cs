using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PFruit
{
    // Polymorphism 多态
    public PFruit()
    {
        Debug.Log("1st Fruit Constructor Called.");
    }

    public void Chop()
    {
        Debug.Log("The Fruit has been chopped.");
    }

    public void SayHello()
    {
        Debug.Log("Hello, I'm a fruit.");
    }
}
