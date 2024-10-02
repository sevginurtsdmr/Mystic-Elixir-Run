using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fog_Manager : MonoBehaviour
{
    public float GreenFogStart;
    public float GreenFogEnd;
    public Color GreenFogColor;
    
    public float GreyFogStart;
    public float GreyFogEnd;
    // Start is called before the first frame update
    void Start()
    {
        ApplyGreyFog(true);
        //ApplyGreenPoisonEffect(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ApplyGreenPoisonEffect(bool activate)
    {
        if (activate)
        {
            // Sis efektini aktif et
            RenderSettings.fog = true;
            RenderSettings.fogMode = FogMode.Linear;
            RenderSettings.fogColor = GreenFogColor; // Sis rengi
            RenderSettings.fogDensity = 0.05f; // Sis yoğunluğu
            RenderSettings.fogStartDistance = GreenFogStart;
            RenderSettings.fogEndDistance = GreenFogEnd;
            Debug.Log("Yeşil sis etkisi aktif.");
        }
        else
        {
            // Sis efektini kapat
            RenderSettings.fog = false;
            Debug.Log("Yeşil sis etkisi kapalı.");
        }
    }

    public void ApplyGreyFog(bool activate)
    {
        if (activate)
        {
            RenderSettings.fog = true;
            RenderSettings.fogMode = FogMode.Linear;
            RenderSettings.fogColor = Color.grey; // Sis rengi
            RenderSettings.fogDensity = 0.05f; 
            RenderSettings.fogStartDistance = GreyFogStart;
            RenderSettings.fogEndDistance = GreyFogEnd;// Sis yoğunluğu
            Debug.Log("Sis etkisi aktif.");
        }
    }
}
