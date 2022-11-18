﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snow_Spwner_2 : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRaneX = 240;
    private float spawnPosZ = -159;
    private float startDelay = 12;
    private float spawnInterval = 10.0f;
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
        Vector3 spawnPos = new Vector3(Random.Range(spawnRaneX, spawnRaneX), 82, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

    }
}