using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFTankBase : MonoBehaviour
{
    [SerializeField] private int moveSpeed;
    public int MoveSpeed
    {
        get { return moveSpeed; }
        set { moveSpeed = value; }
    }


    [SerializeField] private int lifeValue;
    public int LifeValue
    {
        get { return lifeValue; }
        set { lifeValue = value; }
    }

    public int MyProperty { get; set; }

    public void InitTank(int moveSpeed, int lifeValue)
    {
        this.moveSpeed = moveSpeed;
        this.lifeValue = lifeValue;
    }
    public virtual void TankMove()
    {
        Debug.Log("Tank move");
    }

    public virtual void TankShoot()
    {
        Debug.Log("Tank Shoot");
    }

    public override string ToString()
    {
        return string.Format("MoveSpeed:{0},LifeValue:{1}", moveSpeed, lifeValue);
    }



}
