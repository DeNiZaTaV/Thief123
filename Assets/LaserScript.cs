using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    private LineRenderer lr;
    //[SerializeField]
    //private Transform startPoint;



    private void Start()
    {
        lr = GetComponent<LineRenderer>();
    }
    void Update()
    {
        lr.SetPosition(0, transform.position);
        //RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.right, out RaycastHit hit))
        {
            lr.SetPosition(1, hit.point);

            if (hit.collider.CompareTag("Player"))
            {
                Destroy(hit.transform.gameObject);
                
            }
        }
        else
        {
            lr.SetPosition(1, transform.position + transform.right * 5000);
        }
    }
}
