using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    BreakBullet,
    MoveBullet,
    ParalyzeBullet,
    BurnBullet,
    DanceBullet,
    DetectBullet,
    KnockbackBullet,
    LinkBullet,
    FirstAid,
    EnergyItem
}

[CreateAssetMenu(fileName = "New item", menuName= "Inventory/Generic Item")]

public class Item : ScriptableObject
{
    public ItemType itemType;
    public Sprite icon = null;

    public virtual void Use()
    {
        Debug.Log("Using item: " + name);
    }
}
