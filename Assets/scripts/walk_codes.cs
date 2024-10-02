using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk_codes : MonoBehaviour
{
    [SerializeField]
    float Speed;

    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector3.forward * Speed);
    }
}
