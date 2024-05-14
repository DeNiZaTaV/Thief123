using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using DG.tweening;

public class Door3 : MonoBehaviour
{
    public float doorOpeningSpeed = 1f; // Adjust the speed as needed
    public float targetYPosition = 2f; // Adjust the target Y position of the door when fully opened

    public bool doorOpened = false;
    public bool lv1 = false;
    public bool lv2 = false;
    public bool lv3 = false;
    private bool a = false;


    private void Update()
    {
       // Debug.Log("Y Position: " + transform.position.y); // Log the y position for debugging
        if (transform.position.y < 50 && lv3 && a)
        {
            transform.position += (transform.right * 2) * Time.deltaTime;
        }
    }
    public void DoorOpen3()
    {
        lv3 = true;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") )
        {
            a = true;
            Invoke("ResetDoorOpen", 6f);
        }
    }
    private void ResetDoorOpen()
    {
        a = false;
    }
}