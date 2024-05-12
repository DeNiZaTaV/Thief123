using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxhealth;
    public float currenthealth;

    void Start()
    {
        currenthealth = maxhealth;
    }
}