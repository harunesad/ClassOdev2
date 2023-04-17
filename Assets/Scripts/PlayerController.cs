using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CapsuleCollider[] capsules;
    private void Awake()
    {
        capsules = GetComponents<CapsuleCollider>();
    }
    void Start()
    {
        for (int i = 0; i < capsules.Length; i++)
        {
            capsules[i].isTrigger = true;
        }
    }
    void Update()
    {

    }
}//Class
