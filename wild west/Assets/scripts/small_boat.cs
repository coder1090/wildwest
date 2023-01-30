using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class small_boat : MonoBehaviour
{
    public float speed = 20;
    public GameObject enemy;
    public GameObject enemy2;
    public GameObject bad;
    public GameObject bad2;
    public Collider Collider;
    public Collider Collider2;
    public float keepTrack = 0;


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
            enemy.gameObject.SetActive(true);
            enemy2.gameObject.SetActive(true);
            bad.gameObject.SetActive(false);
            bad2.gameObject.SetActive(false);
            Destroy(Collider);
            Destroy(Collider2);



        }
    }
    public void lowerSpeed(int amount)
    {
        speed = amount;
        if (keepTrack == 1) {
            speed = 0;
        }
        keepTrack = 1;

    }
}
