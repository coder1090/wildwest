using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControll : MonoBehaviour
{
    private float speed = 30.0f;
    public float turnSpeed = 200.0f;
    private float horizontalInput;
    private float forwardInput;
    private float spawnDelay = 0;
    public AudioClip fire;
    private float spawnInterval = 0.5f;
    public float zBound = -322.13f;
    public float Zbound = 333.72f;
    private AudioSource playerAudio;

    public GameObject projectitlePrefabs;

    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // this is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the Vehicle Forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //We trun the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        spawnDelay += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.F) && spawnDelay > spawnInterval)
        {
            Instantiate(projectitlePrefabs, transform.position, transform.rotation);
            spawnDelay = 0;
            playerAudio.PlayOneShot(fire, 1.0f);
        }
    }
}
