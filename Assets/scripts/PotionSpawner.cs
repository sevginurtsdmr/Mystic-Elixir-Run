using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionSpawner : MonoBehaviour
{
    public GameObject potion1;
    public GameObject potion2;
    public GameObject potion3;
    public Transform[] spawnPoints; // 1, 2, 3 şeritlerinin pozisyonları
    public float spawnInterval = 2f; // Engellerin spawn olma aralığı
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnItem", 1f, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnItem()
    {
        GameObject PrefabToSpawn;
        int randomItemType = Random.Range(0, 3);
       if (randomItemType ==0)
        {
            PrefabToSpawn = potion1;
        }
        else if (randomItemType == 1)
        {
            PrefabToSpawn = potion2;
        }
        else 
        {
            PrefabToSpawn =potion3;
        }
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(PrefabToSpawn, spawnPoints[randomIndex].position, Quaternion.identity);
    }
    
}

