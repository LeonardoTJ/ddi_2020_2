using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New item", menuName= "Inventory/Health")]

public class HealthItem : Item
{
    void Start()
    {
        itemType = ItemType.FirstAid;
    }

    public override void Use()
    {
        base.Use();
        Health.instance.Heal();
    }
}
