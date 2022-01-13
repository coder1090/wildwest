using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRaneX = 6;
    private float spawnPosZ = -119;
    private float startDelay = 4;
    private float spawnInterval = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomMonster", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        {

        }
    }
    void SpawnRandomMonster()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnRaneX, spawnRaneX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

    }
}