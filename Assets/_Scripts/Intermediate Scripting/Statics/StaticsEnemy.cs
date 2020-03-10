using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticsEnemy
{
    // Static 静态
    // Static variables are shared across all instances of a class
    public static int enemyCount = 0;

    public StaticsEnemy()
    {
        Debug.Log("StaticEnemy 1+" + enemyCount);
        // Increment the static variable to know how many objects of this class have been created
        enemyCount++;
    }
}
