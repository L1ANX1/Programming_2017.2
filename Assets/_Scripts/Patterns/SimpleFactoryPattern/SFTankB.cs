using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFTankB : SFTankBase
{
    public override void TankShoot()
    {
        base.TankShoot();
        Debug.Log("Tank B, shoot teo bullets Once..");
    }
}
