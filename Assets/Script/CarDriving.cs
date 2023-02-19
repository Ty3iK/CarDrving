using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDriving : MonoBehaviour
{
    [SerializeField]
    float _speed;

    void Update()
    {
        if (transform.position.x >= -7 && transform.position.x <= 7)
        {
            if (Input.GetKey(KeyCode.W))
                transform.position += transform.forward * _speed * Time.deltaTime;
            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
                transform.position += transform.forward * _speed * _speed * Time.deltaTime;

            if (Input.GetKey(KeyCode.S))
                transform.position -= transform.forward * _speed * Time.deltaTime;
            if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift))
                transform.position -= transform.forward * _speed * _speed * Time.deltaTime;

            if (Input.GetKey(KeyCode.A))
                transform.Rotate(0, -1, 0);

            if (Input.GetKey(KeyCode.D))
                transform.Rotate(0, 1, 0);
        }
        if (transform.position.x > 5)
            transform.position = new Vector3(5, transform.position.y, transform.position.z);

        if (transform.position.x < -5)
            transform.position = new Vector3(-5, transform.position.y, transform.position.z);

        if (transform.position.z < -149)
            transform.position = new Vector3(transform.position.x, transform.position.y, -149);
    }
}
