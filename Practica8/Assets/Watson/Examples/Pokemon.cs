using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon : MonoBehaviour
{
    public int maxHealth;
    private int currentHealth;
    // Start is called before the first frame update

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

    // Update is called once per frame
    void Update()
    {
        
    }
}
