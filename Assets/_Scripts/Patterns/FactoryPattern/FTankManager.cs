using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FTankManager : MonoBehaviour
{
    private List<string> tankList;
    // private FTankFactory _FTankFactory;
    [SerializeField]
    private GameObject prefab_TankA;
    [SerializeField]
    private GameObject prefab_TankB;
    [SerializeField]
    private GameObject prefab_TankC;


    void Start()
    {
        prefab_TankA = Resources.Load<GameObject>("Patterns/FactoryPattern/TankA");
        prefab_TankB = Resources.Load<GameObject>("Patterns/FactoryPattern/TankB");
        prefab_TankC = Resources.Load<GameObject>("Patterns/FactoryPattern/TankC");
        // _SFTankFactory = gameObject.GetComponent<FTankFactory>();
        tankList = new List<string>();
        tankList.Add("TankA");
        tankList.Add("TankB");
        tankList.Add("TankC");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            int index = Random.Range(0, tankList.Count);
            FITankFactory tankFactory = null;
            FTankBase tankBase = null;
            switch (tankList[index])
            {
                case "TankA":
                    tankFactory = new FTankAFactory();
                    tankBase = tankFactory.CreateTank(prefab_TankA);
                    break;
                case "TankB":
                    tankFactory = new FTankBFactory();
                    tankBase = tankFactory.CreateTank(prefab_TankB);
                    break;
                case "TankC":
                    tankFactory = new FTankCFactory();
                    tankBase = tankFactory.CreateTank(prefab_TankC);
                    break;
            }
            tankBase.TankMove();
            tankBase.TankShoot();
            Debug.Log(tankBase.ToString());
        }
    }


}
