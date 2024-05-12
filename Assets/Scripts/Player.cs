using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public GameObject item;
    // Start is called before the first frame update
    void Start()
    {
        
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
}
