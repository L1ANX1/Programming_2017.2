using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MHWarBand : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        MHumanoid human = new MHumanoid();
        MHumanoid enemy = new MHEnemy();
        MHumanoid orc = new MHOrc();

        // Notice how each Humanoid variable contains a reference to a different class in the inheritance hierarchy,
        // yet each of them calls the Humanoid Yell() method.
        human.Yell();
        enemy.Yell();
        orc.Yell();
    }
}
