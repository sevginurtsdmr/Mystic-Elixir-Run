using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject obstaclePrefab2;
   
    public GameObject coinPrefab;
    public Transform[] spawnPoints; // 1, 2, 3 şeritlerinin pozisyonları
    public float spawnInterval = 2f; // Engellerin spawn olma aralığı

    void Start()
    {
        InvokeRepeating("SpawnItem", 1f, spawnInterval);
    }

    void SpawnItem()
    {
        GameObject PrefabToSpawn;
        int randomItemType = Random.Range(0, 10);

        if (randomItemType == 0)
        {
            PrefabToSpawn = obstaclePrefab;
        }
        else if (randomItemType == 1)
        {
            PrefabToSpawn = obstaclePrefab2;
        }
        else if (randomItemType == 2)
        {
            PrefabToSpawn = obstaclePrefab;
        }
       
        else
        {
            PrefabToSpawn = coinPrefab;
        }
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(PrefabToSpawn, spawnPoints[randomIndex].position, Quaternion.identity);
    }
}


