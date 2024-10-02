using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    [SerializeField]
    float PlaneBackSpeed;
    
    [SerializeField]
    float Threshold = -20;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, PlaneBackSpeed) * Time.deltaTime;
        if (transform.position.z < Threshold)
        {
            transform.position = new Vector3(0,0,0);
            //Debug.Log("kosulsaglandı");
        }
      // Debug.Log(transform.position);
            
    }

   
}
