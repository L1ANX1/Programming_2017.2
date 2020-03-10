using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    // Creating Properties 创建属性
    // Member variables can be referred to as fields
    private int experience;

    // Experience is a basic property
    public int Experience
    {
        get
        {
            // Some other code
            Debug.Log("Experice get value:" + experience);
            return experience;
        }
        set
        {
            // Some other code
            Debug.Log("Experice set value:" + value);
            experience = value;
        }
    }

    // Level is a property that converts experience points into the level of a player automatically
    public int Level
    {
        get
        {
            return experience / 1000;
        }
        set
        {
            experience = value * 1000;
        }
    }

    // This is an example of an auto -implemented
    public int Healty { get; set; }
}
