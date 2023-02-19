using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject _carPrefab;
    void Awake()
    {
        Instantiate(_carPrefab);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
