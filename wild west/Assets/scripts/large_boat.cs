using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class large_boat : MonoBehaviour
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

            int animalIndex3 = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos3 = new Vector3(Random.Range(spawnRaneX, spawnX), -12.73882f, spawnPosZ);

            Instantiate(animalPrefabs[animalIndex3], spawnPos3, animalPrefabs[animalIndex3].transform.rotation);

            int animalIndex4 = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos4 = new Vector3(Random.Range(spawnRaneX, spawnX), -12.73882f, spawnPosZ);

            Instantiate(animalPrefabs[animalIndex4], spawnPos4, animalPrefabs[animalIndex4].transform.rotation);

            int animalIndex5 = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos5 = new Vector3(Random.Range(spawnRaneX, spawnX), -12.73882f, spawnPosZ);

            Instantiate(animalPrefabs[animalIndex5], spawnPos5, animalPrefabs[animalIndex5].transform.rotation);

            int animalIndex6 = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos6 = new Vector3(Random.Range(spawnRaneX, spawnX), -12.73882f, spawnPosZ);

            Instantiate(animalPrefabs[animalIndex6], spawnPos6, animalPrefabs[animalIndex6].transform.rotation);

            int animalIndex7 = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos7 = new Vector3(Random.Range(spawnRaneX, spawnX), -12.73882f, spawnPosZ);

            Instantiate(animalPrefabs[animalIndex7], spawnPos7, animalPrefabs[animalIndex7].transform.rotation);

            int animalIndex8 = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos8 = new Vector3(Random.Range(spawnRaneX, spawnX), -12.73882f, spawnPosZ);

            Instantiate(animalPrefabs[animalIndex8], spawnPos8, animalPrefabs[animalIndex8].transform.rotation);

            int animalIndex9 = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos9 = new Vector3(Random.Range(spawnRaneX, spawnX), -12.73882f, spawnPosZ);

            Instantiate(animalPrefabs[animalIndex9], spawnPos9, animalPrefabs[animalIndex9].transform.rotation);

            int animalIndex10 = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos10 = new Vector3(Random.Range(spawnRaneX, spawnX), -12.73882f, spawnPosZ);

            Instantiate(animalPrefabs[animalIndex10], spawnPos10, animalPrefabs[animalIndex10].transform.rotation);

            int animalIndex11 = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos11 = new Vector3(Random.Range(spawnRaneX, spawnX), -12.73882f, spawnPosZ);

            Instantiate(animalPrefabs[animalIndex11], spawnPos11, animalPrefabs[animalIndex11].transform.rotation);

            int animalIndex12 = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos12 = new Vector3(Random.Range(spawnRaneX, spawnX), -12.73882f, spawnPosZ);

            Instantiate(animalPrefabs[animalIndex12], spawnPos12, animalPrefabs[animalIndex12].transform.rotation);

            int animalIndex13 = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos13 = new Vector3(Random.Range(spawnRaneX, spawnX), -12.73882f, spawnPosZ);

            Instantiate(animalPrefabs[animalIndex13], spawnPos13, animalPrefabs[animalIndex13].transform.rotation);

            int animalIndex14 = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos14 = new Vector3(Random.Range(spawnRaneX, spawnX), -12.73882f, spawnPosZ);

            Instantiate(animalPrefabs[animalIndex14], spawnPos14, animalPrefabs[animalIndex14].transform.rotation);

            int animalIndex15 = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos15 = new Vector3(Random.Range(spawnRaneX, spawnX), -12.73882f, spawnPosZ);

            Instantiate(animalPrefabs[animalIndex15], spawnPos15, animalPrefabs[animalIndex15].transform.rotation);

            Destroy(gameObject);

        }
    }

}


