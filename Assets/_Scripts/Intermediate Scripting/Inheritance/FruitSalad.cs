using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSalad : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // Let's illustrate inheritance with the default constructors.
        Debug.Log("Creating the fruit");
        Fruit myFruit = new Fruit();
        Debug.Log("Creating the apple");
        Apple myApple = new Apple();

        // // Call the methods of the Fruit class
        // myFruit.SayHello();
        // myFruit.Chop();

        // // Call the methods of the Apple class.
        // // Notice how Class Apple has access to all of the public methods of Class Fruit.
        // myApple.SayHello();
        // myApple.Chop();

        // Call the methods of the Apple class.
        // Notice how class Apple has access to all of the public methods of Class Fruit.
        Debug.Log("Creating the Fruit");
        myFruit = new Fruit("yellow");
        Debug.Log("Creating the apple");
        myApple = new Apple("green");

        // Call the methods of the Fruit class
        myFruit.SayHello();
        myFruit.Chop();

        // Call the methods of the Apple class.
        // Notice how class Apple has access to all of the public methods of class Fruit.
        myApple.SayHello();
        myApple.Chop();
    }


}
