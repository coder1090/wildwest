using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desroy_bad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bulite")) 
        {
            GameManger.GetGameManger.UpdateScore(10);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
           
        }
        if (collision.gameObject.CompareTag("player_2"))
        {
            Destroy(gameObject);

        }
    }

}
