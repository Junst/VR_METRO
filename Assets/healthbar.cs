using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthbar : MonoBehaviour {

    private Transform bar;

	private void Start (){
        bar = transform.Find("Bar:);
    }
	
    public void Setsize(float sizeNormalized)
    {
        bar.localScale = new.Vector3(sizeNormalized, 1f);
            
    }
	void Update () {
		
	}
}
