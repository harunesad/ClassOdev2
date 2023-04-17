using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjeYakalama : MonoBehaviour
{
    Camera cam;
    private void Awake()
    {
        
    }
    void Start()
    {
        cam = (Camera)FindObjectOfType(typeof(Camera));
    }
    void Update()
    {
        
    }
}
