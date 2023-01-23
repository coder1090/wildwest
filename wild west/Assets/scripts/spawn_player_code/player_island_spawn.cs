using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_island_spawn : MonoBehaviour
{
    public GameObject[] humans;
    private float spawnRangeX = -11.96357f;
    private float spawnPosZ = 26.17f;
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
            int humansIndex = Random.Range(0, humans.Length);
            Vector3 spawnPos = new Vector3(Random.Range(spawnRangeX, spawnRangeX), -11.25091f, spawnPosZ);

            Instantiate(humans[humansIndex], spawnPos, humans[humansIndex].transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            space = false;
        }
    }
}
