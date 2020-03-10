using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ListsAndDictionaries
{
    public class SomeClass : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            // This is how you create a list. Notice how the type
            // is specifiec in the angle bracket(<>)
            List<BadGuy> badGuys = new List<BadGuy>();

            // Here you add 3 BadGuys to the List
            badGuys.Add(new BadGuy("Harvey", 50));
            badGuys.Add(new BadGuy("Magneto", 100));
            badGuys.Add(new BadGuy("Pip", 5));

            badGuys.Sort();

            foreach (BadGuy guy in badGuys)
            {
                print(guy.name + " " + guy.power);
            }

            // This clears out the list so that it is empty.
            badGuys.Clear();
        }

    }
}