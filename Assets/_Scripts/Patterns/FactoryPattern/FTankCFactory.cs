using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FTankCFactory : FITankFactory
{
    public FTankBase CreateTank(GameObject go)
    {
        FTankBase tankBase = GameObject.Instantiate(go).GetComponent<FTankBase>();
        tankBase.InitTank(6, 300);
        return tankBase;
    }
}

