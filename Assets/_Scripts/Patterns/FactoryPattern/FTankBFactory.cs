using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FTankBFactory : FITankFactory
{
    public FTankBase CreateTank(GameObject go)
    {
        FTankBase tankBase = GameObject.Instantiate(go).GetComponent<FTankBase>();
        tankBase.InitTank(4, 200);
        return tankBase;
    }
}

