using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFTankManager : MonoBehaviour
{
    private List<string> tankList;
    private SFTankFactory _SFTankFactory;

    void Start()
    {
        _SFTankFactory = gameObject.GetComponent<SFTankFactory>();
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
            SFTankBase tankBase = _SFTankFactory.CreateTank(tankList[index]);
            tankBase.TankMove();
            tankBase.TankShoot();
            Debug.Log(tankBase.ToString());
        }
    }
}
