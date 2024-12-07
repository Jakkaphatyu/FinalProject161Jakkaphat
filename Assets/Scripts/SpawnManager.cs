using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject coinPrefab;
    public GameObject bombPrefab;
    public float spawnInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating("SpawnObject", 0f, spawnInterval);
    }

    private void SpawnObject()
    {
        // สุ่มวัตถุที่จะ Spawn
        GameObject objectToSpawn = Random.Range(0, 2) == 0 ? coinPrefab : bombPrefab;

        // สุ่มตำแหน่งในแนวนอน
        Vector2 spawnPosition = new Vector2(Random.Range(-8f, 8f), Random.Range(-4f, 4f));

        // สร้างวัตถุ
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }
}
