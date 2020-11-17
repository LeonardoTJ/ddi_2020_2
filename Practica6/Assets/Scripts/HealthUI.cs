using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUI : MonoBehaviour
{
    public GameObject player;
    Health playerHealth;
    public HealthItem healthIcon;
    
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = player.GetComponent<Health>();
        playerHealth.onChange += UpdateUI;
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
            if(i <= playerHealth.currentHealth)
                slots[i].SetItem(healthIcon);
            else
                slots[i].Clear();
        }
    }
}
