using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth_2 : MonoBehaviour
{
    [SerializeField] private List<GameObject> uiHealth;
    [SerializeField] private int maxHealth;
    private int currentHealth;
    private bool isDead;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = uiHealth.Count;
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            isDead = true;
        }
        //deactivate all healths above current health
        for (int i = 0; i < maxHealth; i++)
        {
            if (i < currentHealth)
            {
                uiHealth[i].SetActive(true);
            }
            else
            {
                uiHealth[i].SetActive(false);

            }
        }
    }
    public bool PlayerAlive()
    {
        return !isDead;
    }
}
