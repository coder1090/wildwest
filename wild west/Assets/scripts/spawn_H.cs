using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_H : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float spawnrangex = 0;
    public float spawnposz = -18;
    public float spawnrangeY = -8;
    public float startDelay = 12;
    public float spawnInterval = 10.0f;
    public bool space = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && space)
        {
            InvokeRepeating("SpawnRandomMonster", startDelay, spawnInterval);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            space = false;
        }
    }
    void SpawnRandomMonster()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnrangex, spawnrangex), spawnrangeY, spawnposz);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

    }
}
