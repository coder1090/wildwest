using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_3 : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnrangex = 56;
    private float spawnposz = -162;
    private float startDelay = 10;
    private float spawnInterval = 7.0f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            InvokeRepeating("SpawnRandomMonster", startDelay, spawnInterval);
        }
    }
    void SpawnRandomMonster()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnrangex, spawnrangex), 0, spawnposz);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

    }
}
