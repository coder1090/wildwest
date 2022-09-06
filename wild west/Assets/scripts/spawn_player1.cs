using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_player1 : MonoBehaviour
{
    public bool prespace = false;
    public GameObject[] humans;
    private float spawnRangeX = 0.001f;
    private float spawnPosZ = -175;
    private bool space = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && prespace && space)
        {
            int humansIndex = Random.Range(0, humans.Length);
            Vector3 spawnPos = new Vector3(Random.Range(spawnRangeX, spawnRangeX), 0, spawnPosZ);

            Instantiate(humans[humansIndex], spawnPos, humans[humansIndex].transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.Space)&& prespace)
        {
            space = false;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            prespace = true;
        }
    }
}
