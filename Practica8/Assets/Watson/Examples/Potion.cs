using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : Item
{
    public int healthRecovery = 5;
    // Start is called before the first frame update
    void Start()
    {
        name = "Potion";
    }

    public int Use()
    {
        return healthRecovery;
    }
}
