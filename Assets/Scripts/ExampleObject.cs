using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleObject : MonoBehaviour
{
    TrailRenderer trail;
    [SerializeField] float speed = 4;
    public List<float> values;
    private void Awake()
    {
        trail = GetComponentInChildren<TrailRenderer>();
    }
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            values[i] = trail.widthCurve.keys[i].value;
        }
        trail.time = 1;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
            transform.Translate(Vector3.up * speed * 2 * Time.deltaTime);
            trail.time = .5f;
            trail.startColor = new Color(0, 0.1f, 1, 1);
            trail.endColor = new Color(.4f, .7f, .2f, .5f);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            //transform.Translate(Vector3.down * speed * Time.deltaTime);
            transform.rotation = new Quaternion(0, 0, 180, 0);
            transform.Translate(Vector3.up * speed * 2 * Time.deltaTime);
            trail.time = .25f;
            trail.startColor = Color.magenta;
            trail.endColor = Color.red;
            //transform.Rotate(Vector3.forward * Time.deltaTime * 50);
            //for (int i = 0; i < 5; i++)
            //{
            //    trail.widthCurve.keys[i].value = values[4 - i];
            //}
        }
        else
        {
            trail.time = .25f;
        }
    }
}
