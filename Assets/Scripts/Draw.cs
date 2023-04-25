using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour
{
    LineRenderer line;
    private void Awake()
    {
        line = GetComponent<LineRenderer>();
    }
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform != null)
                {
                    line.SetVertexCount(line.positionCount + 1);
                    line.SetPosition(line.positionCount - 1, hit.point + Vector3.up);
                }
            }
        }
    }
}
