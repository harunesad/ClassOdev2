using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMover : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(Vector3.back * 10 * Time.deltaTime);
    }
}
