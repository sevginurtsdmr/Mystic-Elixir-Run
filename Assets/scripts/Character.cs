using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Character : MonoBehaviour
{   private int konumdurumu = 2;
    public float moveSpeed = 5f; 
    public static int PlayerCoin;
    public TextMeshProUGUI CoinText;
    public int PlayerPotion;
    public TextMeshProUGUI PotionText;
    public int health = 3; // Karakterin mevcut canı
    public int maxHealth = 5; // Karakterin maksimum canı
    public AudioSource AudioSource;
    
    public AudioClip CoinSoundClip;
    public AudioClip PotionSoundClip;

   
    
    public bool IsVisible = true;
    void Start()
    {
        PlayerCoin = 0;
       
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Jump();
        }
    }

    public void IncreaseHealth(int amount)
    {
        health += amount;
        if (health > maxHealth)
        {
            health = maxHealth; // Canı maksimum değeri aşamaz
        }

        Debug.Log("Current Health: " + health);
    }
    private void FixedUpdate()
    {
        VisibleControl();
    }
    public void VisibleControl()
    {
        if (IsVisible == false)
        {
            StartCoroutine(ResetVisibility());
        }
    }
    private IEnumerator ResetVisibility()
    {
        yield return new WaitForSeconds(3);
        toggleVisibility(false);
    }

    public void toggleVisibility(bool open)
    {
        if (open == true)
        { 
            SkinnedMeshRenderer renderer = gameObject.GetComponentInChildren<SkinnedMeshRenderer>();
            foreach (Material mat in renderer.materials)
            {
                
                SetMaterialTransparent(mat);
                
                Color color = mat.color;
                color.a = 0.5f;
                mat.color = color;
            }

            IsVisible = false;
            Debug.Log("Görünmezlikaçık");
        }
        else
        {
            SkinnedMeshRenderer renderer = gameObject.GetComponentInChildren<SkinnedMeshRenderer>();
            foreach (Material mat in renderer.materials)
            {
                SetMaterialOpaque(mat);
                Color color = mat.color;
                color.a = 1f;
                mat.color = color;
            }
            IsVisible = true;
            Debug.Log("görünmezlikkapalı");
        }
        

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {   
             
            PlayerCoin++;
            CoinText.text = "" + PlayerCoin;
            Debug.Log("benkarakterparayacarptım");
            if(PlayerCoin>PlayerPrefs.GetInt("highScore"))
            {
                PlayerPrefs.SetInt("highScore", PlayerCoin);
            }

            AudioSource.clip = CoinSoundClip;
            AudioSource.Play();
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("potion"))
        {
            PlayerPotion++;
            PotionText.text = "" + PlayerPotion;
            Debug.Log("iksiralındı");
            
            AudioSource.clip = PotionSoundClip;
            AudioSource.Play();
             // Destroy(other.gameObject);
        }
    }
    
    void SetMaterialTransparent(Material mat)
    {
        mat.SetFloat("_Mode", 3);
        mat.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
        mat.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
        mat.SetInt("_ZWrite", 0);
        mat.DisableKeyword("_ALPHATEST_ON");
        mat.EnableKeyword("_ALPHABLEND_ON");
        mat.DisableKeyword("_ALPHAPREMULTIPLY_ON");
        mat.renderQueue = 3000;
    }
    // void SetMaterialTransparent(Material mat)
    // {
    //     mat.shader = Shader.Find("Mobile/Particles/Alpha Blended");
    //
    //     Color color = mat.color;
    //     color.a = 0.5f;  // Alpha değeri ile saydamlığı ayarlıyoruz
    //     mat.color = color;
    //
    // }

    void SetMaterialOpaque(Material mat)
    {
        mat.SetFloat("_Mode", 0);
        mat.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.One);
        mat.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.Zero);
        mat.SetInt("_ZWrite", 1);
        mat.DisableKeyword("_ALPHATEST_ON");
        mat.DisableKeyword("_ALPHABLEND_ON");
        mat.DisableKeyword("_ALPHAPREMULTIPLY_ON");
        mat.renderQueue = -1;
    }

    public void Jump()
    { 
        Debug.Log("Hopladı");
    }
}
