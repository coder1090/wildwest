using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_player2W : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 16;
    private float spawnPosZ = -175;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(spawnRangeX, spawnRangeX), 0, spawnPosZ);

            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
