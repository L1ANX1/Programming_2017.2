using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticsGame : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        StaticsEnemy enemy1 = new StaticsEnemy();
        StaticsEnemy enemy2 = new StaticsEnemy();
        StaticsEnemy enemy3 = new StaticsEnemy();

        // You can access a static variable by using the class name and the dot operator;
        int x = StaticsEnemy.enemyCount;
        Debug.Log("Game enemy count: " + x);
    }

}
