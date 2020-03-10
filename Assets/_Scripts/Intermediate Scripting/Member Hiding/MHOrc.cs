using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MHOrc : MHEnemy
{
    // This hides the Enemy version.
    public new void Yell()
    {
        Debug.Log("Orc version of the Yell() method");
    }
}
