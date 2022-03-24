using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_spawn : MonoBehaviour
{
    private float startDelay = 0.0011f;
    private float spawnInterval = 0.0011f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InvokeRepeating("destroy", startDelay, spawnInterval);
        }
        
    }
    void destroy()
    {
       
        Destroy(gameObject);
    }
}
