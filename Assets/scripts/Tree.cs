using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    [SerializeField] float TreeBackSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, TreeBackSpeed) * Time.deltaTime;
        if (transform.position.z < -20)
        {
            //Debug.Log("yokoluyorum");
            Destroy(gameObject);
        }
        
    }
}
