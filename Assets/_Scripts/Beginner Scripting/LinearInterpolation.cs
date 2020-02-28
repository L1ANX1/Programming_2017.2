using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolation : MonoBehaviour {
	// Linear Interpolation
	// 线性插值

	private Light mLight;
	// Use this for initialization
	void Start () {
		mLight = GetComponent<Light> ();
		float result = Mathf.Lerp (3f, 5f, 0.5f);
		print ("result : " + result);

		Vector3 from = new Vector3 (1f, 2f, 3f);
		Vector3 to = new Vector3 (5f, 6f, 7f);
		Vector3 result3 = Vector3.Lerp (from, to, 0.75f);
		print ("result3 : " + result3);
	}

	// Update is called once per frame
	void Update () {
		mLight.intensity = Mathf.Lerp (mLight.intensity, 8f, 0.5f * Time.deltaTime);
	}
}