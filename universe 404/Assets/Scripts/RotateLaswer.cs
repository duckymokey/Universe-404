using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLaswer : MonoBehaviour
{
    public Transform rayDirection;
    public LineRenderer lineRenderer;
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        //����LineRendererd��λ��
        lineRenderer.SetPosition(0, transform.position);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, rayDirection.transform.position);
        if (hit)
        {
            lineRenderer.SetPosition(1, hit.point);
        }
        if(hit.collider.tag == "Player")
        {
            Debug.Log("YOU DIED");
        }
    }

}
