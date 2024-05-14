using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using DG.tweening;

public class Door1 : MonoBehaviour
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
        if (transform.position.y < 5 && lv1 && a)
        {
            transform.position += (transform.right * 2) * Time.deltaTime;

        }
    }
    public void DoorOpen1()
    {
        lv1 = true;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            a = true;
            Invoke("ResetDoorOpen", 5f);
        }
    }
    private void ResetDoorOpen()
    {
        a = false;
    }
}