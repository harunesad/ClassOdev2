using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineManager : MonoBehaviour
{
    public static LineManager lineManager;
    public bool restart = true;
    public GameObject linePrefab;
    private void Awake()
    {
        lineManager = this;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && restart)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform != null)
                {
                    if (FindObjectOfType<Draw>() != null)
                    {
                        Destroy(FindObjectOfType<Draw>());
                        //var lineRend = Instantiate(linePrefab);
                        //lineRend.transform.position = hit.point;
                        //lineRend.GetComponent<LineRenderer>().SetVertexCount(1);
                        //lineRend.GetComponent<LineRenderer>().SetPosition(0, hit.point);
                        Debug.Log("if içi");
                    }
                    Debug.Log("if dışı");
                    var line = Instantiate(linePrefab);
                    line.GetComponent<LineRenderer>().materials[0].color = Random.ColorHSV(0, 1, 0, 1, 0, 1, 0, 1);
                    line.transform.position = hit.point;
                    line.GetComponent<LineRenderer>().SetVertexCount(1);
                    line.GetComponent<LineRenderer>().SetPosition(0, hit.point);
                    line.AddComponent<Draw>();
                    restart = false;
                }
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            restart = true;
        }
    }
}
