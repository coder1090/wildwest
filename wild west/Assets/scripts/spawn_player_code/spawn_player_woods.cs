﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_player_woods : MonoBehaviour
{
    public GameObject[] playerM1;
    private float spawnRangeX = 17;
    private float spawnPosZ = 30;
    private bool space = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && space)
        {
            int playerM1Index = Random.Range(0, playerM1.Length);
            Vector3 spawnPos = new Vector3(Random.Range(spawnRangeX, spawnRangeX), -12, spawnPosZ);

            Instantiate(playerM1[playerM1Index], spawnPos, playerM1[playerM1Index].transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            space = false;
        }
    }
}