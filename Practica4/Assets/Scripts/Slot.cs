using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Image image;
    public Item item;
    private Inventory inventory;

    // Start is called before the first frame update
    void Start()
    {
        inventory = FindObjectOfType<Inventory>();
        if(inventory == null)
        {
            Debug.LogWarning("Inventory not found");
            return;
        }
        if(item != null)
        {
            image.sprite = item.icon;
        }
    }

    public void SetItem(Item item)
    {
        this.item = item;
        if(item == null)
        {
            Debug.LogWarning("Image null");
            return;
        }
        image.sprite = item.icon;
        image.enabled = true;
    }

    public void Clear()
    {
        this.item = null;
        image.sprite = null;
        image.enabled = false;
    }

    public void RemoveFromInventory()
    {
        if(this.item != null)
        {
            inventory.Remove(this.item);
        }
    }

    public void UseItem()
    {
        if(item != null)
        {
            item.Use();
            RemoveFromInventory();
        }
    }
}
