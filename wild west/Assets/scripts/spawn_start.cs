using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class spawn_start : MonoBehaviour
{
    // this code is for spawns
    public GameObject west;
    public Button westButton;
    public GameObject woods;
    public Button woodsButton;
    public GameObject medow;
    public Button medowButton;
    public GameObject snow;
    public Button snowButton;
    public GameObject farm;
    public Button farmButton;
    public GameObject cave;
    public Button caveButton;
    public GameObject island;
    public Button islandButton;
    public GameObject time;
    public Button timeButton;
    //this code is for the maps
    public GameObject westMap;
    public GameObject woodMap;
    public GameObject medowMap;
    public GameObject snowMap;
    public GameObject farmMap;
    public GameObject caveMap;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        westButton.onClick.AddListener(westSpawn);
        woodsButton.onClick.AddListener(woodSpawn);
        medowButton.onClick.AddListener(medowSpawn);
        snowButton.onClick.AddListener(snowSpawn);
        farmButton.onClick.AddListener(farmSpawn);
        caveButton.onClick.AddListener(caveSpawn);
        islandButton.onClick.AddListener(islandSpawn);
        timeButton.onClick.AddListener(timeSpawn);
    }
    public void westSpawn(){
        west.gameObject.SetActive(true);
        westMap.gameObject.SetActive(true);
    }
    public void woodSpawn()
    {
        woods.gameObject.SetActive(true);
        woodMap.gameObject.SetActive(true);
    }
    public void medowSpawn()
    {
        medow.gameObject.SetActive(true);
        medowMap.gameObject.SetActive(true);
    }
    public void snowSpawn()
    {
        snow.gameObject.SetActive(true);
        snowMap.gameObject.SetActive(true);
    }
    public void farmSpawn()
    {
        farm.gameObject.SetActive(true);
        farmMap.gameObject.SetActive(true);
    }
    public void caveSpawn()
    {
        cave.gameObject.SetActive(true);
        caveMap.gameObject.SetActive(true);
    }
    public void islandSpawn()
    {
        island.gameObject.SetActive(true);
    }
    public void timeSpawn()
    {
        time.gameObject.SetActive(true);
    }
}
