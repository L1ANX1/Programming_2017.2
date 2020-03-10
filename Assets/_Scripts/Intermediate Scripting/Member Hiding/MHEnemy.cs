using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MHEnemy : MHumanoid
{
    // This hides the Humanoid version.
    public new void Yell()
    {
        Debug.Log("Enemy version of the Yell() method");
    }

}
