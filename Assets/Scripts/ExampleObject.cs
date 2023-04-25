using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleObject : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {
        transform.Rotate(Vector3.right * 100 * Time.deltaTime);
    }
}
