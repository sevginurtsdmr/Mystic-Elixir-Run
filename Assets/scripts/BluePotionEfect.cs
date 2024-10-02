using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePotionEfect : MonoBehaviour
{
    public float potionDuration = 30.0f; // İksirin etkisinin süresi (saniye)
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
                Character character = other.gameObject.GetComponent<Character>();
                if (character != null)
                {
                    character.toggleVisibility(true);
                }
                Destroy(gameObject);
        }
        else
        {
            Debug.Log("character yok hocam");
        }
    }
    private IEnumerator ResetVisibilityAfterTime(Character character)
    {
        character.toggleVisibility(false); // Görünürlüğü geri getir
        
        yield return new WaitForSeconds(30); // Süre kadar bekle
        Debug.Log("Potion effect ended, character is visible again.");
    }
   
   
}
