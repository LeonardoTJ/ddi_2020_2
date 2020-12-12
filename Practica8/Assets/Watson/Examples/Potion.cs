using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : Item
{
    public int healthRecovery = 5;
    
    void Start()
    {
        name = "Potion";
    }

    public override int Use()
    {
        return healthRecovery;
    }
}
