using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemyattack : MonoBehaviour
{
    public GameObject sword;
    public float hitForce = 10f;
    public bool isattaking = false;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetBool("Ataa", true);
            isattaking = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            animator.SetBool("Ataa", false);
            isattaking = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            if (isattaking)
            {
                Rigidbody enemyRb = other.GetComponent<Rigidbody>();
                Vector3 hitDirection = other.transform.position - transform.position;
                Vector3 force = hitDirection * hitForce;
                enemyRb.AddForce(force, ForceMode.Impulse);

                other.GetComponent<Enemyy>().enemyhealth -= 10;

            }
        }
    }
}  
  
