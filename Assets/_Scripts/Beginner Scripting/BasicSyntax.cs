﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSyntax : MonoBehaviour
{
    // 约定和语法
    // Conventions and Syntax

    // Use this for initialization
    void Start()
    {
        // this line is there to tell me ...
        /* Hi there!
        * This is two lines!
        * */
        Debug.Log(transform.position.x);
        if (transform.position.y <= 5f)
            Debug.Log("I'm about to hit the ground!");

    }

}