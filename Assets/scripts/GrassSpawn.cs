using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassSpawn : MonoBehaviour
{
    public GameObject grassPrefab; // Çim prefab'ı
    public int numberOfGrass = 100; // Oluşturulacak çim sayısı
    public float areaWidth = 10f; // Çimlerin yayılacağı alanın genişliği (x ekseni)
    public float areaHeight = 10f; // Çimlerin yayılacağı alanın uzunluğu (z ekseni)
    public float minY = 0f; // Çimlerin minimum yüksekliği (y ekseni)
    public float maxY = 0f; // Çimlerin maksimum yüksekliği (y ekseni)
    public float spawnInterval = 1f; 
    void Start()
    {
        InvokeRepeating("SpawnGrass", 1f, spawnInterval);
    }

    void SpawnGrass()
    {
        for (int i = 0; i < numberOfGrass; i++)
        {
            float randomX = Random.Range(-areaWidth / 2, areaWidth / 2);
            float randomY = Random.Range(minY, maxY);
            float randomZ = Random.Range(-areaHeight / 2, areaHeight / 2);

            Vector3 randomPosition = new Vector3(randomX, randomY, randomZ);

            Instantiate(grassPrefab, randomPosition, Quaternion.identity);
        }
    }
}
