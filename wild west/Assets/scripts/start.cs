using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public float speed = 10.0f;
    public float zBound = -227.2f;
    public float Zbound = -123.4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);

        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * -speed);

        }

        ConstrainPlayerPoistion();
    }
    void ConstrainPlayerPoistion()
    {

        if (transform.position.z < zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }
        if (transform.position.z > Zbound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, Zbound);
        }
    }
}
