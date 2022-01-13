using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = -98;
    public float lowerBound = -220;
    public float rightBound = 75;
    public float leftBound = -64;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);

        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
