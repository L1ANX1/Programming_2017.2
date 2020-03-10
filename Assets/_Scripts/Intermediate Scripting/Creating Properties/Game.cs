using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Player mPlayer = new Player();

        // Properties can be used just like variabled
        mPlayer.Experience = 5;
        int x = mPlayer.Experience;
        Debug.Log("Level " + mPlayer.Level);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
