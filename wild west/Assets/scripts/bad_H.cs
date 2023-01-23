using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bad_H : MonoBehaviour
{
    private float speed = -7;
    public float startDelay = 1;
    public float spawnInterval = 1;
    public float turnSpeed = 90;
    public float time = 2;
    public float time2 = 2; 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("forward", startDelay, spawnInterval);
        InvokeRepeating("turn", time, time2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void forward ()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    void turn()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed);
    }
}

