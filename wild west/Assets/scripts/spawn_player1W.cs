﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_player1W : MonoBehaviour
{
    public GameObject[] humans;
    private float spawnRangeX = 4;
    private float spawnPosZ = -175;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            int humansIndex = Random.Range(0, humans.Length);
            Vector3 spawnPos = new Vector3(Random.Range(spawnRangeX, spawnRangeX), 4, spawnPosZ);

            Instantiate(humans[humansIndex], spawnPos, humans[humansIndex].transform.rotation);
        }
    }
}

