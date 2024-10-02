using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPotionEffect : MonoBehaviour
{
    public int healAmount = 1; // İksir can artırma miktarı

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HealthSystem healthSystem = other.GetComponent<HealthSystem>();
            if (healthSystem != null)
            {
                healthSystem.IncreaseHealth(healAmount); // Can ekle
                Debug.Log("Red potion collected. Health increased.");
            }

            Destroy(gameObject); // İksiri yok et
        }
    }
    // public int healthIncreaseAmount = 1; // Can artışı miktarı
    //
    // private void OnTriggerEnter(Collider other)
    // {
    //     if (other.CompareTag("Player")) // Eğer çarpan "Player" etiketi taşıyorsa
    //     {
    //         Character character = other.gameObject.GetComponent<Character>(); // Karakter bileşenini al
    //         if (character != null)
    //         {
    //             character.IncreaseHealth(healthIncreaseAmount); // Canı artır
    //             Debug.Log("Red potion collected. Health increased.");
    //         }
    //         else
    //         {
    //             Debug.LogError("Character component not found on the player.");
    //         }
    //
    //         Destroy(gameObject); // İksiri yok et
    //     }
    // }
}
