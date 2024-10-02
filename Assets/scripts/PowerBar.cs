using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerBar : MonoBehaviour
{

    public float power;
    public float animationslowly;
    private float maxPower, realScale;
    // Start is called before the first frame update
    void Start()
    {
        maxPower = power;
    }

    // Update is called once per frame
    void Update()
    {
        realScale = power / maxPower;
        if (transform.localScale.x > realScale)
        {
            transform.localScale = new Vector3(transform.localScale.x - (transform.localScale.x - realScale) / animationslowly,
                transform.localScale.y, transform.localScale.z);
        }

        if (Input.GetKeyDown("a"))
        {
            power -= 100;
        }
    }
}
