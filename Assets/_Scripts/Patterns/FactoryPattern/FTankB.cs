using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FTankB : FTankBase
{
    public override void TankShoot()
    {
        base.TankShoot();
        Debug.Log("Tank B, shoot teo bullets Once..");
    }
}
