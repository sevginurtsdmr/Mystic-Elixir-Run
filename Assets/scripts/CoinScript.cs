using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CoinScript : MonoBehaviour
{
    [SerializeField] private float CoinSpeed;

    private void Start()
    {
        transform.position += new Vector3(0, 1, 0);
    }

    void Update()
    {
        
        transform.position += new Vector3(0, 0, CoinSpeed) * Time.deltaTime;
        
        if (transform.position.z < -20)
        {
            
            // Destroy(gameObject);}}
        }
    }
    
   
}
