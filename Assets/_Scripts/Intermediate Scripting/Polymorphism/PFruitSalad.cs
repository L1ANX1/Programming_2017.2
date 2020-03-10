using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PFruitSalad : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // Notice here how the variable "myFruit" is of type
        // Fruit but is being assigned a referece to an apple.
        // This works because of Polymorphism. 
        // Since an Apple is a Fruit, this works just fine.
        // While the Apple reference is stored in a Fruit variable, it can only be used like a Fruit
        PFruit myFruit = new PApple();

        myFruit.SayHello();
        myFruit.Chop();

        // This is called downcasting. The variable "myFruit" which is of type Fruit,
        // actually contains a reference to an Apple. Therefore, it can safely be turned back into an Apple Variable.
        // This allows it to be used like an Apple, where before it could only be used like a Fruit.
        PApple myApple = (PApple)myFruit;

        myApple.SayHello();
        myApple.Chop();
    }


}
