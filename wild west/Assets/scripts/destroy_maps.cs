using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class destroy_maps : MonoBehaviour
{
    public Button west_button;
    public Button wood_button;
    public Button medow_button;
    public Button snow_button;
    public Button farm_button;
    public Button cave_button;
    public Button island_button;
    public Button WhatCouldItBe_button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        west_button.onClick.AddListener(destroy);
        wood_button.onClick.AddListener(destroy);
        medow_button.onClick.AddListener(destroy);
        snow_button.onClick.AddListener(destroy);
        farm_button.onClick.AddListener(destroy);
        cave_button.onClick.AddListener(destroy);
        island_button.onClick.AddListener(destroy);
        WhatCouldItBe_button.onClick.AddListener(destroy);

    }
    void destroy()
    {
        Destroy(gameObject);
    }
}
