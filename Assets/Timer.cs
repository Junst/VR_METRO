using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {
    private float time = 0;

	void Update () {
        time += Time.deltaTime;
        Debug.Log(time);
	}
}
