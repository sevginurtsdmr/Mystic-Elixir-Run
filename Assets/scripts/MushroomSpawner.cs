using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomSpawner : MonoBehaviour
{
    
    public GameObject itemprefab1;
    public GameObject itemprefab2;
    public GameObject itemprefab3;
    public GameObject itemprefab4;
    public GameObject itemprefab5;

    public Transform[] spawnPoints;
    public float spawnInterval;
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
        int randomItemType = Random.Range(0, 5);

        if (randomItemType == 0)
        {
            PrefabToSpawn = itemprefab1;
        }
        else if (randomItemType == 1)
        {
            PrefabToSpawn = itemprefab2;
        }
        else if (randomItemType == 2)
        {
            PrefabToSpawn = itemprefab3;
        }
        else if (randomItemType == 3)
        {
            PrefabToSpawn = itemprefab5;
        }
        else 
        {
            PrefabToSpawn = itemprefab4;
        }
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(PrefabToSpawn, spawnPoints[randomIndex].position, Quaternion.identity);
    }
}
