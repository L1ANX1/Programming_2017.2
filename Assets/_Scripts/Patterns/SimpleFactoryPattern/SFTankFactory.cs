using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFTankFactory : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab_TankA;
    [SerializeField]
    private GameObject prefab_TankB;
    [SerializeField]
    private GameObject prefab_TankC;

    void Awake()
    {
        prefab_TankA = Resources.Load<GameObject>("Patterns/SimpleFactoryPattern/TankA");
        prefab_TankB = Resources.Load<GameObject>("Patterns/SimpleFactoryPattern/TankB");
        prefab_TankC = Resources.Load<GameObject>("Patterns/SimpleFactoryPattern/TankC");
    }

    public SFTankBase CreateTank(string tankName)
    {
        SFTankBase tankBase = null;
        switch (tankName)
        {
            case "TankA":
                tankBase = GameObject.Instantiate(prefab_TankA).GetComponent<SFTankBase>();
                tankBase.InitTank(2, 100);
                break;
            case "TankB":
                tankBase = GameObject.Instantiate(prefab_TankB).GetComponent<SFTankBase>();
                tankBase.InitTank(4, 200);
                break;
            case "TankC":
                tankBase = GameObject.Instantiate(prefab_TankC).GetComponent<SFTankBase>();
                tankBase.InitTank(6, 300);
                break;
        }
        return tankBase;
    }
}
