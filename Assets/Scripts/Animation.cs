using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    Animator anim;

    bool move = false, run = false, jump = false;
    [SerializeField] AudioSource footStep;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            move = true;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            move = false;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            run = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            run = false;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Jump");
        }
        anim.SetBool("Move", move);
        anim.SetBool("Run", run);
    }
}
