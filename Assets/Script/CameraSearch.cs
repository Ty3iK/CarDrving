using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSearch : MonoBehaviour
{
    [SerializeField]
     CarDriving _car;
    private void Start()
    {
        _car = FindObjectOfType<CarDriving>();
    }
    private void LateUpdate()
    {
       transform.position = _car.transform.position + new Vector3(0, 3.7f, -6);
    }
}
