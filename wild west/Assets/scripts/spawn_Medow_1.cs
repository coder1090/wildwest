﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_Medow_1 : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRaneX = -74;
    private float spawnPosZ = 41;
    private float startDelay = 6;
    private float spawnInterval = 5.0f;
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
        Vector3 spawnPos = new Vector3(Random.Range(spawnRaneX, spawnRaneX), -15, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

    }
}