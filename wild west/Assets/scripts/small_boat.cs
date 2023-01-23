using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class small_boat : MonoBehaviour
{
    public float speed = 20;
    public GameObject[] animalPrefabs;
    public float spawnRaneX = 0;
    public float spawnX = 0;
    public float spawnPosZ = -18;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            speed = 0;
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(spawnRaneX, spawnX), -12.73882f, spawnPosZ);

            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

            int animalIndex2 = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos2 = new Vector3(Random.Range(spawnRaneX, spawnX), -12.73882f, spawnPosZ);

            Instantiate(animalPrefabs[animalIndex2], spawnPos2, animalPrefabs[animalIndex2].transform.rotation);
            Destroy(gameObject);

        }
    }
   
}
