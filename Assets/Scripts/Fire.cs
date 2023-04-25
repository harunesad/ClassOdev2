using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    LineRenderer line;
    ParticleSystem particle;
    public Transform target;
    void Start()
    {
        line = GetComponentInChildren<LineRenderer>();
        particle = GetComponentInChildren<ParticleSystem>();
    }
    void Update()
    {
        line.SetPosition(0, transform.position);
        line.SetPosition(1, target.position);
        if (Input.GetKey(KeyCode.R))
        {
            particle.Play();
        }
    }
}
