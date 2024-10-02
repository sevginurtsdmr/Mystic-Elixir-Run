using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public float jumpForce = 5f;  // Zıplama kuvveti
    private bool isGrounded;      // Karakterin yerde olup olmadığını kontrol eder
    private Rigidbody rb;         // Karakterin Rigidbody bileşeni

    private void Start()
    {
        // Rigidbody bileşenini al
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Zıplama tuşuna basıldığında ve karakter yerdeyken zıplama
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    private void Jump()
    {
        // Yukarıya doğru kuvvet uygula
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isGrounded = false;  // Zıplama sonrası karakter yerde değil
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Karakter yere değerse zıplama izni ver
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
