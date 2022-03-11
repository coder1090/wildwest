using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_player1 : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 0.001f;
    private float spawnPosZ = -175;
    private float startDelay = 0.001f;
    private float spawnInterval = 10000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InvokeRepeating("SpawnRandomMonster", startDelay, spawnInterval);
        }
    }

    void SpawnRandomMonster()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

    }
}
