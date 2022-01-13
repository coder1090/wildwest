using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_2 : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnrangex = -44;
    private float spawnposz = -167;
    private float startDelay = 8;
    private float spawnInterval = 6.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomMonster", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomMonster()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnrangex, spawnrangex), 0, spawnposz);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

    }
}
