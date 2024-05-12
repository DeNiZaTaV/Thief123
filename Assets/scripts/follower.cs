using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class follower : MonoBehaviour
{
    public float distance = 10;
    private NavMeshAgent agent;
    public Transform target;
    public bool isHit = false;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            if (Vector3.Distance(transform.position, target.position) < distance)  
            {
                agent.SetDestination(target.position);
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!isHit) 
            {
                StartCoroutine(HitDelay());
            }
        }
    }

    IEnumerator HitDelay()
    {
        isHit = true;
        Rigidbody enemyRigidbody = GetComponent<Rigidbody>();
        if (enemyRigidbody != null)
        {
            enemyRigidbody.velocity = Vector3.zero; // Düşmanın hızını sıfırla
            enemyRigidbody.angularVelocity = Vector3.zero; // Düşmanın açısal hızını sıfırla
        }
        yield return new WaitForSeconds(3f);
        isHit = false;
    }
}
