using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryUIpanel;
    // public GameObject inventoryButton;
    private Inventory inventory;
    public static PickupObject itemOnRange;
    // Start is called before the first frame update
    void Start()
    {
        inventory = FindObjectOfType<Inventory>();
        if(inventory == null)
        {
            Debug.LogWarning("Inventory not found");
            return;
        }
        inventoryUIpanel.SetActive(false);
        inventory.onChange += UpdateUI;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Pickup()
    {
        if(itemOnRange != null)
        {
            itemOnRange.Interact();
        }
    }

    public void UpdateUI()
    {
        inventoryUIpanel.SetActive(!inventoryUIpanel.activeSelf);
        if(inventoryUIpanel.activeSelf)
        {
            Slot[] slots = GetComponentsInChildren<Slot>();
            for(int i = 0; i < slots.Length; i++)
            {
                if(i < inventory.items.Count)
                {
                    slots[i].SetItem(inventory.items[i]);
                }
                else
                {
                    slots[i].Clear();
                }
            }
        }
    }
}
