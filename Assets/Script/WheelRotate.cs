using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotate : MonoBehaviour
{
    [SerializeField]
    GameObject _wheels;
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
            _wheels.transform.Rotate(10, 0, 0);
    }
}
