﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; // This allows the ICompareable Interface

namespace ListsAndDictionaries
{
    // List and Dictionaries 列表和字典
    // This is the class you will be storing
    // in the different collection. In order to use
    // a collection's Sort() method, this class needs to
    // implement the IComparable interface
    public class BadGuy : IComparable<BadGuy>
    {
        public string name;
        public int power;

        public BadGuy(string newName, int newPower)
        {
            name = newName;
            power = newPower;
        }

        // This method is required by the IComparable interface
        public int CompareTo(BadGuy other)
        {
            if (other == null)
                return 1;

            // Return the different in power
            return power - other.power;
        }
    }
}