using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] private GameObject[] hearts;
    
    private int lifeAmount;
    private bool isDead;
    
    public CameraShake MyCameraShake;

    private void Start()
    {
        lifeAmount = hearts.Length;
        MyCameraShake = GameObject.Find("Main Camera").GetComponent<CameraShake>();
    }

    private void Update()
    {
        
    }

    public void TakeDamage(int damageAmount)
    {
        MyCameraShake.Shake(0.3f,0.05f);
        
        lifeAmount -= damageAmount;
        // Destroy(hearts[lifeAmount].gameObject);
        
        if (lifeAmount >= 0)
        {
            hearts[lifeAmount].SetActive(false); // Kalbi görünmez yap
        }
        Debug.Log("benimcanım=" + lifeAmount);

        if (lifeAmount < 1)
        {
            isDead = true;
            Debug.Log("ÖLDÜN");
            SceneManager.LoadScene("Scenes/isDeadScene");
        }
    }
    public void IncreaseHealth(int healAmount)
    {
        // Can ekle
        if (lifeAmount < hearts.Length) // Eğer maksimum cana ulaşılmamışsa
        {
            hearts[lifeAmount].SetActive(true); // Kalbi tekrar görünür yap
            lifeAmount += healAmount; // Can miktarını artır
            Debug.Log("Can eklendi, mevcut can: " + lifeAmount);
        }
    }
}
