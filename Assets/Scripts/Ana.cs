using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ana : MonoBehaviour
{
    CapsuleCollider[] capsules;
    private void Awake()
    {
        capsules = GetComponentsInChildren<CapsuleCollider>();
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
}
