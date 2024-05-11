using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using DG.tweening;

public class Door2 : MonoBehaviour
{
    public float doorOpeningSpeed = 1f; // Adjust the speed as needed
    public float targetYPosition = 2f; // Adjust the target Y position of the door when fully opened

    public bool doorOpened = false;
    public bool lv1 = false;
    public bool lv2 = false;
    public bool lv3 = false;
  


    private void Update()
    {
        Debug.Log("Y Position: " + transform.position.y); // Log the y position for debugging
        if (transform.position.y < 5 && lv2)
        {
            transform.position += (transform.right * 2) * Time.deltaTime;
            
        }
       
    }

    private void Start()
    {
        
        
    }
    private void OpenDoor()
    {
        /*Door1 door1 = GetComponent<Door1>(); // Get instance of Door1 component attached to the same GameObject hangisini yap?caksan onun door numar?s?n? de?i?tir
        door1.DoorOpen1(); // Call */
    }
    public void DoorOpen2()
    {
        lv2 = true;
    }
}

