using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : Interactable
{
    public Inventory inventory;
    public Item item;

    public override void Interact()
    {
        base.Interact();
        Debug.Log("Pickup object");
        if(inventory.Add(item))
        {
            DisableInteract();
            Destroy(gameObject);
        }
    }

    protected override void EnableInteract()
    {
        base.EnableInteract();
        MessageText[0].text = item.name;
        icon.sprite = item.icon;
    }
}
