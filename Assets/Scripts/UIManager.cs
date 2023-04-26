using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Image healthBarAlt, healthBarUst;
    private void Awake()
    {
        
    }
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            healthBarUst.fillAmount -= .25f;
        }
    }
}
