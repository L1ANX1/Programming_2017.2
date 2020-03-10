using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar : MonoBehaviour, IKillable, IDamageable<float>
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // The required method of the IKillable interface
    public void Kill()
    {
        // Do something fun
    }

    // The required method of the IDamageable interface
    public void Damage(float damageTaken)
    {
        // Do something fun
    }
}
