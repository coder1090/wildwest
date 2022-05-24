using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_over2 : MonoBehaviour
{
    PlayerHealth_2 health;
    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<PlayerHealth_2>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        health.TakeDamage(1);
        if (health.PlayerAlive())
        {
            return;
        }
        else
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        
    }
}
