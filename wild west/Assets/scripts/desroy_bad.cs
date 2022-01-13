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
        Destroy(gameObject);
        if (other.gameObject.CompareTag("Hittable")) 
        {
            Destroy(other.gameObject);
        }
    }
}
