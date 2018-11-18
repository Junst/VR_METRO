using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainController : MonoBehaviour {
    [SerializeField] private Transform startPointTr;
    [SerializeField] private Transform endPointTr;

    private void Start()
    {
        gameObject.transform.position = startPointTr.position;
    }

    private void Update()
    {
        if (gameObject.transform.position.z < endPointTr.transform.position.z)
            return;
        // 전동차 움직이는 코드
    }

}
