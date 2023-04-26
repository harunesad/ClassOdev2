using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Image rocket;
    private void Awake()
    {
        
    }
    void Start()
    {
    StartCoroutine(DestroyImage());
    }
    void Update()
    {
        
    }
    IEnumerator DestroyImage()
    {
        for (int i = 0; i < 5; i++)
        {
            yield return new WaitForSeconds(1.3f);
            rocket.fillAmount -= .25f;
        }
    }
}
