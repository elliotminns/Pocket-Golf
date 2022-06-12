using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(LineRenderer))]
public class line_path : MonoBehaviour
{

    public LineRenderer lr;
    public Rigidbody2D rb;

    public GameObject ballObject;

    public float counter = 0f;

    public Color defaultStart = new Color(1.0F, 1.0F, 1.0F, 1.0F);
    public Color defaultEnd = new Color(1.0F, 1.0F, 1.0F, 0.0F);
    public Color maxStart = new Color(1.0F, 0.0F, 0.0F, 1.0F);
    public Color maxEnd = new Color(1.0F, 0.0F, 0.0F, 0.0F);

    private void Awake()
    {
        ballObject = GameObject.FindWithTag("Ball");
        lr = GetComponent<LineRenderer>();
        rb = GetComponent<Rigidbody2D>();
        lr.positionCount = 0;
        lr.enabled = true;
    }

    private void Update()
    {
        if (rb.velocity.magnitude == 0)
        {
            counter += Time.deltaTime;
        }
        else
        {
            counter = 0;
            lr.enabled = false;
        }

        if (counter >= 0.3)
        {
            lr.enabled = true;
        }
    }

    public void RenderLine(Vector3 ballPos, Vector3 lineEnd)
    {
        if (rb.velocity.magnitude == 0)
        {
            lr.positionCount = 2;
            Vector3[] points = new Vector3[2];
            points[0] = ballPos;
            points[1] = Vector3.MoveTowards(ballPos, lineEnd, 1.5f);

            lr.SetPositions(points);

            if (Vector3.Distance(ballPos, lineEnd) > 1.5)
            {
                lr.startColor = maxStart;
                lr.endColor = maxEnd;
            }
            else
            {
                lr.startColor = defaultStart;
                lr.endColor = defaultEnd;
            }
        }

    }

    public void EndLine()
    {
        lr.positionCount = 0;
    }
}
