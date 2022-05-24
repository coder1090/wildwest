using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class game_over_screan : MonoBehaviour
{
    public GameObject camera;
    [SerializeField] private Vector3 cameraPos;
    public Button restartButton;

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
        restartButton.gameObject.SetActive(true);
        var myCamera= SpawnCamera();
        myCamera.tag = "Main Camera";
    }
    GameObject SpawnCamera()
    {

        return Instantiate(camera, cameraPos, camera.transform.rotation);

    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
