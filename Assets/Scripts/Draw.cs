using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour
{
    LineRenderer line;
    EdgeCollider2D edge;
    Vector3 linePoint;
    private void Awake()
    {
        line = GetComponent<LineRenderer>();
        edge = GetComponent<EdgeCollider2D>();
    }
    void Start()
    {
        
    }
    void Update()
    {
        //if (Input.GetMouseButton(0) && LineManager.lineManager.restart)
        //{
        //    var lineRend = Instantiate(gameObject);
        //    lineRend.GetComponent<LineRenderer>().SetVertexCount(1);
        //    lineRend.transform.position = Input.mousePosition;
        //    lineRend.AddComponent<Draw>();
        //    LineManager.lineManager.restart = false;
        //    Destroy(GetComponent<Draw>());
        //    return;
        //}
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

                    List<Vector2> points = new List<Vector2>();
                    for (int i = 0; i < line.positionCount; i++)
                    {
                        if (i == 0)
                        {
                            linePoint = Vector3.zero;
                        }
                        else
                        {
                            linePoint = line.GetPosition(i) - line.GetPosition(0);
                            //linePoint = new Vector3(linePoint.x + points[0].x, linePoint.y, linePoint.z + points[0].y);
                        }
                        points.Add(new Vector2(linePoint.x, linePoint.y));
                    }
                    edge.SetPoints(points);
                }
            }
        }
        //if (Input.GetMouseButtonUp(0))
        //{
        //    LineManager.lineManager.restart = true;
        //}
    }
}
