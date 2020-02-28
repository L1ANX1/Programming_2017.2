using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour {
    // 变量和函数
    // Variables and Functions

    public int myInt = 5;
    // Use this for initialization
    void Start () {
        myInt = MultiplyByTwo (myInt);
        Debug.Log (myInt);
    }

    int MultiplyByTwo (int number) {
        int ret;
        ret = number * 2;
        return ret;
    }
}