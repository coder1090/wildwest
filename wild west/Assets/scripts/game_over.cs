﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_over : MonoBehaviour
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
        GameObject.FindObjectOfType<game_over_screan>().GameOver();
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
