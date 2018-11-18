using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeController : MonoBehaviour {
    private int hp = 100;
    private const int hpCutValue = 5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Controller"))
        {
            hp -= hpCutValue;
            Debug.Log(hp);
            if(hp <=0)
                gameObject.SetActive(false);
        }
    }
}
