using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class maps : MonoBehaviour
{
    public Button mapsText;
    public Image map1;
    public bool prestSpace = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            map1.gameObject.SetActive(true);
            mapsText.gameObject.SetActive(true);
            prestSpace = true;
        }
        if (Input.GetKeyDown(KeyCode.Space)&& prestSpace)
        {
            map1.gameObject.SetActive(false);
            mapsText.gameObject.SetActive(false);

        }
    }
}
