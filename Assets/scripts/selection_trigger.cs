using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selection_trigger : MonoBehaviour
{
    public GameObject roadSection;
    [SerializeField]
    float SpawnDistance;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("trigger"))
        {
            Instantiate(roadSection, new Vector3(0,0,SpawnDistance), Quaternion.Euler(270,0,0));

        }
    }
}
