using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleObject : MonoBehaviour
{
    TrailRenderer trail;
    [SerializeField] float speed = 4;
    private void Awake()
    {
        trail = GetComponentInChildren<TrailRenderer>();
    }
    void Start()
    {
        trail.time = 1;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * speed * 2 * Time.deltaTime);
            trail.time = 2;
            trail.startColor = new Color(1, 1, 1, 1);
            trail.endColor = new Color(.4f, .7f, .2f, .5f);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
            trail.time = .75f;
        }
        else
        {
            trail.time = .25f;
        }
    }
}
