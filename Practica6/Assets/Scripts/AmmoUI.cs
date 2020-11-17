using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoUI : MonoBehaviour
{
    public GameObject player;
    Ammo playerAmmo;
    
    // Start is called before the first frame update
    void Start()
    {
        playerAmmo = player.GetComponent<Ammo>();
        playerAmmo.onChange += UpdateUI;
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
            if(i < Inventory.instance.bullets.Count && i <= playerAmmo.currentAmmo)
                slots[i].SetItem(Inventory.instance.bullets[i]);
            else
                slots[i].Clear();
        }
    }
}