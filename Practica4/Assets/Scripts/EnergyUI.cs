using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyUI : MonoBehaviour
{
    public GameObject player;
    Energy playerEnergy;
    public EnergyItem energyIcon;
    
    // Start is called before the first frame update
    void Start()
    {
        playerEnergy = player.GetComponent<Energy>();
        playerEnergy.onChange += UpdateUI;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        Slot[] slots = GetComponentsInChildren<Slot>();
        for(int i = 0; i < slots.Length; i++)
        {
            if(i <= playerEnergy.currentEnergy)
                slots[i].SetItem(energyIcon);
            else
                slots[i].Clear();
        }
    }
}
