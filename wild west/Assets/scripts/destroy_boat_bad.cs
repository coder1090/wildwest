using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_boat_bad : MonoBehaviour
{
    small_boat boat;

    // Start is called before the first frame update
    void Start()
    {
        boat = GetComponent<small_boat>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bulite"))
        {
            boat.lowerSpeed(3);

        }
    }

}