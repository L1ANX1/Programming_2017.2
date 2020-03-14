using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FTankC : FTankBase
{
    public override void TankShoot()
    {
        base.TankShoot();
        Debug.Log("Tank C, shoot three bullets Once...");
    }
}
