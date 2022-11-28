using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_over : MonoBehaviour
{
    PlayerHealth health;
    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<PlayerHealth>();
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
            GameObject.FindObjectOfType<game_over_screan>().GameOver();
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
