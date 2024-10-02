using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMover : MonoBehaviour
{
    [SerializeField]
    float PlaneBackSpeed;
    
    [SerializeField]
    float Threshold = -20;
    
    [SerializeField]
    float spawnPoint = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, PlaneBackSpeed) * Time.deltaTime;
        if (transform.position.z < Threshold)
        {
            transform.position = new Vector3(0,0,spawnPoint);
            //Debug.Log("kosulsaglandı");
        }
    }
}
