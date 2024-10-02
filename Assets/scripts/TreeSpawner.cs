using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    public GameObject treePrefab1;
    public GameObject treePrefab2;
    public GameObject treePrefab3;
    public GameObject treePrefab4;
    public GameObject itemprefab1;
    public GameObject itemprefab2;
    public GameObject itemprefab3;
    public GameObject itemprefab4;
    public GameObject itemprefab5;
    public GameObject itemprefab6;
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
        int randomItemType = Random.Range(0, 10);

        if (randomItemType == 0)
        {
            PrefabToSpawn = treePrefab1;
        }
        else if (randomItemType == 1)
        {
            PrefabToSpawn = treePrefab2;
        }
        else if (randomItemType == 2)
        {
            PrefabToSpawn = treePrefab3;
        }
        else if (randomItemType == 3)
        {
            PrefabToSpawn = treePrefab4; 
        }
        else if (randomItemType == 4)
        {
            PrefabToSpawn = itemprefab1;
        }
        else if (randomItemType == 5)
        {
            PrefabToSpawn = itemprefab2;
        }
        else if (randomItemType == 6)
        {
            PrefabToSpawn = itemprefab3;
        }
        else if (randomItemType == 7)
        {
            PrefabToSpawn = itemprefab4;
        }
        else if (randomItemType == 8)
        {
            PrefabToSpawn = itemprefab5;
        }
        else 
        {
            PrefabToSpawn =itemprefab6;
        }
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(PrefabToSpawn, spawnPoints[randomIndex].position, Quaternion.identity);
    }
}
