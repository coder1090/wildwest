using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class spawn_west : MonoBehaviour
{
    public GameObject[] west;
    public float westX = 7.3f;
    public float westZ = -98.0f;
    public Button westButon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        westButon.onClick.AddListener(westSpwan);
    }
    public void westSpwan(){
        int westIndex = Random.Range(0, west.Length);
        Vector3 spawnPos = new Vector3(Random.Range(westX, westX), 0, westZ);

        Instantiate(west[westIndex], spawnPos, west[westIndex].transform.rotation);
    }
}
