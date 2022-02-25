using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_over_screan : MonoBehaviour
{
    public GameObject camera;
    [SerializeField] private Vector3 cameraPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void GameOver()
    {
        var myCamera= SpawnCamera();
        myCamera.tag = "Main Camera";
    }
    GameObject SpawnCamera()
    {

        return Instantiate(camera, cameraPos, camera.transform.rotation);

    }
}
