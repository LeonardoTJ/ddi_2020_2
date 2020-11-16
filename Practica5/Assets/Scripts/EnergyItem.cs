using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New item", menuName= "Inventory/Energy")]

public class EnergyItem : Item
{
    void Start()
    {
        itemType = ItemType.EnergyItem;
    }

    public override void Use()
    {
        base.Use();
        Energy.instance.Recharge();
    }
}
