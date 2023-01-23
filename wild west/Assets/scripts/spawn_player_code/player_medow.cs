using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_medow : MonoBehaviour
{
    public GameObject[] humans;
    private float spawnRangeX = 6.788f;
    private float spawnPosZ = 8.580001f;
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
            Vector3 spawnPos = new Vector3(Random.Range(spawnRangeX, spawnRangeX), -1.4f, spawnPosZ);

            Instantiate(humans[humansIndex], spawnPos, humans[humansIndex].transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            space = false;
        }
    }
}
