using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    ParticleSystem particle;
    private void Awake()
    {
        particle = GetComponent<ParticleSystem>();
    }
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            particle.Play();
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            particle.Stop();
        }
    }
    private void OnParticleSystemStopped()
    {
        Debug.Log("jhgh");
    }
}
