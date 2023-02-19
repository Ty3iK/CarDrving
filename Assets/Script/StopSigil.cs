using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSigil : MonoBehaviour
{
    [SerializeField]
    GameObject _backLight;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            Material m = _backLight.GetComponent<Material>();
            m.SetColor(name, Color.white);
        }
        if (Input.GetKeyUp(KeyCode.S))
            _backLight.GetComponent<Material>().SetColor(name, Color.red);

    }
}
