using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPotionEffect : MonoBehaviour
{
    public float potionDuration = 5.0f; // İksirin etkisinin süresi (saniye)
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Character character = other.gameObject.GetComponent<Character>();
            Fog_Manager fogManager = GameObject.Find("FogWall").GetComponent<Fog_Manager>();
            if (character != null)
            {
                fogManager.ApplyGreenPoisonEffect(true); // Sis efektini başlat
                StartCoroutine(ResetFogAfterTime(character)); // Belirli süre sonra sis efektini kapat
            }
            //gameObject.SetActive(false);
            GetComponent<MeshRenderer>().enabled = false;
            // İksiri yok et
        }
        else
        {
            Debug.Log("Player bulunamadı.");
        }
    }

    private IEnumerator ResetFogAfterTime(Character character)
    {
        yield return new WaitForSeconds(potionDuration);
        Fog_Manager fogManager = GameObject.Find("FogWall").GetComponent<Fog_Manager>();// Süre kadar bekle
        fogManager.ApplyGreyFog(true); // Sis etkisini geri al
        Debug.Log("Sis etkisi sona erdi.");
        Destroy(gameObject);
    }
}
