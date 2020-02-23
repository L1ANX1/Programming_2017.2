using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleBehaviourScript : MonoBehaviour {
    // 作为行为组件的脚本
    // Scripts as Behaviour Components

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown (KeyCode.R)) { GetComponent<Renderer> ().material.color = Color.red; }
        if (Input.GetKeyDown (KeyCode.G))
            GetComponent<Renderer> ().material.color = Color.green;
        if (Input.GetKeyDown (KeyCode.B))
            GetComponent<Renderer> ().material.color = Color.blue;

    }
}