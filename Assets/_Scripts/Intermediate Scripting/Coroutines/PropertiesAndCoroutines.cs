using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertiesAndCoroutines : MonoBehaviour
{
    public float smooth = 7f;
    public Vector3 Target
    {
        get { return target; }
        set
        {
            target = value;
            StopCoroutine("Movement");
            StartCoroutine("Movement", target);
        }
    }

    private Vector3 target;

    IEnumerator Movement(Vector3 target)
    {
        while (Vector3.Distance(transform.position, target) > 0.05f)
        {
            transform.position = Vector3.Lerp(transform.position, target, smooth * Time.deltaTime);
            yield return null;
        }
    }
}
