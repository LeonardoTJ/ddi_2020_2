using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon : MonoBehaviour
{
    public int maxHealth;
    public string name;
    public int def;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public int GetHealth()
    {
        return currentHealth;
    }
    
    public int GetMaxHealth()
    {
        return maxHealth;
    }

    public bool ReceiveDamage()
    {
        currentHealth -= 1;
        return (currentHealth < 1);
    }
}
