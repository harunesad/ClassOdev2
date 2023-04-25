using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    LineRenderer line;
    ParticleSystem particle;
    AudioSource fire;
    public Transform target;
    float time = 0;
    void Start()
    {
        line = GetComponentInChildren<LineRenderer>();
        particle = GetComponentInChildren<ParticleSystem>();
        fire = GetComponentInChildren<AudioSource>();
    }
    void Update()
    {
        line.SetPosition(0, transform.position);
        line.SetPosition(1, target.position);
        time += Time.deltaTime;
        if (Input.GetKey(KeyCode.R) && time < 2)
        {
            particle.Play();
            fire.Play();
        }
    }
}
