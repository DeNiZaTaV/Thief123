using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuzak : MonoBehaviour
{
    [SerializeField]
    public GameObject objectToSpawn;
    [SerializeField]
    public Vector3 spawnAreaMin;
    [SerializeField]
    public Vector3 spawnAreaMax;
    [SerializeField]
    public int numberOfObjectsToSpawn = 20;

    void Start()
    {
       SpawnLoop();
    }
    public void SpawnLoop()
    {
       

       
        for (int i = 0; i < numberOfObjectsToSpawn; i++)
        {
            SpawnObject();
        }
    }



    public void SpawnObject()

    {
        // Generate random coordinates within the spawn area
        float randomX = Random.Range(spawnAreaMin.x, spawnAreaMax.x);
        float randomZ = Random.Range(spawnAreaMin.z, spawnAreaMax.z);

        // Create a new Vector3 with the random coordinates and a z value of 0 (assuming 2D)
        Vector3 spawnPosition = new Vector3(randomX, -1 ,randomZ );

        // Instantiate the object at the random position
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);

       
    }

  

}
