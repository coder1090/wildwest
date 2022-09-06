using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_player2 : MonoBehaviour
{
    public GameObject[] humans;
    private float spawnRangeX = 16;
    private float spawnPosZ = -175;
    private bool X = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && X)
        {
            int humansIndex = Random.Range(0, humans.Length);
            Vector3 spawnPos = new Vector3(Random.Range(spawnRangeX, spawnRangeX), 0, spawnPosZ);

            Instantiate(humans[humansIndex], spawnPos, humans[humansIndex].transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            X = false;
        }

    }
}
