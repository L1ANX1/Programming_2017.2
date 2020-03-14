using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FTankAFactory : FITankFactory
{
    public FTankBase CreateTank(GameObject go)
    {
        FTankBase tankBase = GameObject.Instantiate(go).GetComponent<FTankBase>();
        tankBase.InitTank(2, 100);
        return tankBase;
    }
}
