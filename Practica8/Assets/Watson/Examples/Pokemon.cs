﻿using System.Collections;
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

    public void Heal(int amount)
    {
        Debug.Log("Heal amount:" + amount);
        currentHealth += amount;
        if(currentHealth > maxHealth)
            currentHealth = maxHealth;
    }

    public bool ReceiveDamage()
    {
        currentHealth -= 10;
        return (currentHealth < 1);
    }
}
