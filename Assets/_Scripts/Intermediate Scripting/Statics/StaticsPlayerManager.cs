using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticsPlayerManager : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // You can access a static variable by using the class name and the dot operator
        int x = StaticsPlayer.playerCount;
        Debug.Log("PlayerManager player count: " + x);
    }

}
