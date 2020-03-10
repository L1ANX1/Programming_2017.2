using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegatesScript : MonoBehaviour
{
    // Delegates 委托

    delegate void MyDelegate(int num);
    MyDelegate myDelegate;

    // Use this for initialization
    void Start()
    {
        myDelegate = PrintNum;
        myDelegate(50);

        myDelegate = DoubleNum;
        myDelegate(50);

    }

    void PrintNum(int num)
    {
        print("Print Num: " + num);
    }

    void DoubleNum(int num)
    {
        print("Double Num: " + num * 2);
    }
}
