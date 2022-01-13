using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class payer_2 : MonoBehaviour
{
    private float speed = 15.0f;
    public float turnSpeed = 200.0f;
    private float horizontalInput;
    private float forwardInput;
    private float spawnDelay = 0;
    private float spawnInterval = 0.5f;

    public GameObject projectitlePrefabs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // this is where we get player input
        horizontalInput = Input.GetAxis("Horizontal_2");
        forwardInput = Input.GetAxis("Vertical_2");

        // Move the Vehicle Forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //We trun the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        spawnDelay += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.H) && spawnDelay > spawnInterval)
        {
            Instantiate(projectitlePrefabs, transform.position, transform.rotation);
            spawnDelay = 0;
        }
    }
}
