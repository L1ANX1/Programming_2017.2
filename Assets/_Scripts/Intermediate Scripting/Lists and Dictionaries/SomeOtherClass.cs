using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ListsAndDictionaries
{
    public class SomeOtherClass : MonoBehaviour
    {
        // Use this for initialization
        void Start()
        {
            // This is how you create a Dictionary. Notice how this takes
            // two generic terms. In this case you are using a string and a
            // BadGuy as your two values
            Dictionary<string, BadGuy> badGuys = new Dictionary<string, BadGuy>();

            BadGuy bg1 = new BadGuy("Harvey", 50);
            BadGuy bg2 = new BadGuy("Magneto", 100);

            // You can place variables into the Dictionary with the Add() method
            badGuys.Add("gangster", bg1);
            badGuys.Add("mutant", bg2);

            BadGuy magneto = badGuys["mutant"];
            BadGuy temp = null;

            // This is a safer, but slow, method of accessing
            if (badGuys.TryGetValue("birds", out temp))
            {
                // Success!
                print("Success");
            }
            else
            {
                // Failure!
                print("Failure");
            }
        }
    }
}