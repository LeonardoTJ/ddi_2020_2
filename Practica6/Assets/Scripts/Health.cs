using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public delegate void OnChange();
    public OnChange onChange;
    public int currentHealth = 1;
    public const int maxHealth = 5;
    public static Health instance;

    void Start()
    {
        instance = this;
    }
    
    public void Heal()
    {
        currentHealth += 1;

        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}
