using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public float doorOpeningSpeed = 1f; // Adjust the speed as needed
    public float targetYPosition = 2f; // Adjust the target Y position of the door when fully opened

    public bool doorOpened = false;
    public bool lv1 = true;
    public bool lv2 = false;
    public bool lv3 = false;
    public bool lv4 = false;


    private void Update()
    {
        Debug.Log("Y Position: " + transform.position.y); // Log the y position for debugging
        if (transform.position.y < 5 && doorOpened)
        {
            transform.position += (transform.right * 2) * Time.deltaTime;
        }
    }
}

