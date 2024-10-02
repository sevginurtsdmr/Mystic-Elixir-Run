using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] float ObstacleBackSpeed;

    [SerializeField] private int damage = 1;

    // Update is called once per frame
    void Update()
    {
         transform.position += new Vector3(0, 0, ObstacleBackSpeed) * Time.deltaTime;
        if (transform.position.z < -20)
        {
            //Debug.Log("yokoluyorum");
            Destroy(gameObject);
        }
        // Debug.Log(transform.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("benkütükkarakterecarptım");

            bool Visible = other.GetComponent<Character>().IsVisible;
            
            if (Visible)
            {
                other.gameObject.GetComponent<HealthSystem>().TakeDamage(damage);
            }
            // Destroy(gameObject);
        }
    }
}