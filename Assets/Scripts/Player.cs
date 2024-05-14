using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Door1 door1; // Assign the Door1 GameObject in the Inspector
    public Door2 door2; // Assign the Door2 GameObject in the Inspector
    public Door3 door3; // Assign the Door3 GameObject in the Inspector
    public Canvas Key1;//assign the Key1 Canvas
    public Canvas Key2;// assign the key2 canvas
    public Canvas Key3;// assign the key3 canvas

    public GameObject item;
    // Start is called before the first frame update
    void Start()
    {
        // Ensure the Key canvases are initially inactive
        Key1.gameObject.SetActive(false);
        Key2.gameObject.SetActive(false);
        Key3.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("TakeItem"))
        {
            if (Input.GetKeyDown(KeyCode.E)) 
            {
                Destroy(item);
            }
        }

       

            

                
        

                
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("key1"))
        {
            if (door1 != null)
            {
                door1.DoorOpen1();
                Key1.gameObject.SetActive(true);
                Destroy(collision.gameObject);

            }
        }
        else if (collision.gameObject.CompareTag("key2"))
        {
            if (door2 != null)
            {
                door2.DoorOpen2();
                Key2.gameObject.SetActive(true);
                Destroy(collision.gameObject);
            }
        }
        else if (collision.gameObject.CompareTag("key3"))
        {
            if (door3 != null)
            {
                door3.DoorOpen3();
                Key3.gameObject.SetActive(true);
                Destroy(collision.gameObject);
            }
        }
    }
}
