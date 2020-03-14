using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFTankA : SFTankBase
{
    public override void TankShoot()
    {
        base.TankShoot();
        Debug.Log("Tank A, shoot a bullet Once.");
    }
}
