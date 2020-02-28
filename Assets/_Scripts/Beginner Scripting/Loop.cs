using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour {
    // 循环

    public bool startForLoop = false;
    public bool startForWhile = false;
    public bool startDoWhileLoop = false;
    public bool startForEachLoop = false;

    // Use this for initialization
    void Start () {
        if (startForLoop)
            ForLoop ();
        if (startForWhile)
            WhileLoop ();
        if (startDoWhileLoop)
            DoWhileLoop ();
        if (startForEachLoop)
            ForeachLoop ();
    }

    void ForLoop () {
        int numEnemies = 3;
        for (int i = 0; i < numEnemies; i++) {
            Debug.Log ("Creating enemy number: " + i);
        }
    }

    void WhileLoop () {
        int cupsInTheSink = 4;
        while (cupsInTheSink > 0) {
            Debug.Log ("I've washed a cup!");
            cupsInTheSink--;
        }
    }

    void DoWhileLoop () {
        bool shouldContinue = false;
        do {
            print ("Hello World");
        }
        while (shouldContinue == true);
    }

    void ForeachLoop () {
        string[] strings = new string[3];
        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";

        foreach (string item in strings)
            print (item);
    }
}