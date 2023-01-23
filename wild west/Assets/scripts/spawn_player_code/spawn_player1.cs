using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_player1 : MonoBehaviour
{
    public GameObject[] humans;
    private float spawnRangeX = -0.8080013f;
    private float spawnPosZ = -15.50046f;
    private bool space = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& space)
        {
            int humansIndex = Random.Range(0, humans.Length);
            Vector3 spawnPos = new Vector3(Random.Range(spawnRangeX, spawnRangeX), -2.11f, spawnPosZ);

            Instantiate(humans[humansIndex], spawnPos, humans[humansIndex].transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            space = false;
        }
    }
}
