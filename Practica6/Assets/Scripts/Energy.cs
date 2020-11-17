using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy : MonoBehaviour
{
    public delegate void OnChange();
    public OnChange onChange;
    public int currentEnergy = 1;
    public const int maxEnergy = 5;
    public static Energy instance;

    void Start()
    {
        instance = this;
    }
    
    public void Recharge()
    {
        currentEnergy += 1;

        if(currentEnergy > maxEnergy)
        {
            currentEnergy = maxEnergy;
        }
    }
}
