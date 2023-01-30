using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class island_spawner : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float spawnRaneX = -7.48812f;
    public float spawnPosZ = 314.2252f;
    public float spawnPosY = 8.56f;
    public float startDelay = 24;
    public float spawnInterval = 20.0f;
    public bool space = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKeyDown(KeyCode.Space) && space)
            {
                InvokeRepeating("SpawnRandomMonster", startDelay, spawnInterval);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            space = false;
        }
    }
    void SpawnRandomMonster()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnRaneX, spawnRaneX), spawnPosY, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

    }
}