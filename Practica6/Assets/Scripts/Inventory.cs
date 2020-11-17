using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public delegate void OnChange();
    public OnChange onChange;
    public int space = 9;
    public List<Item> items = new List<Item>();
    public List<Item> bullets = new List<Item>();
    public static Inventory instance;

    void Start()
    {
        instance = this;
    }

    public bool isFull()
    {
        return items.Count >= space;
    }

    public bool Add(Item item)
    {
        if(!isFull())
        {
            switch(item.itemType)
            {
                case ItemType.BreakBullet:
                case ItemType.MoveBullet:
                case ItemType.ParalyzeBullet:
                case ItemType.BurnBullet:
                case ItemType.DanceBullet:
                case ItemType.DetectBullet:
                case ItemType.KnockbackBullet:
                case ItemType.LinkBullet:      bullets.Add(item);
                                               Ammo.instance.LoadBullet();
                                               break;
                case ItemType.FirstAid:
                case ItemType.EnergyItem:      item.Use();
                                               break;
            }
            if(onChange != null)
            {
                onChange.Invoke();
            }
            return true;
        }
        else
        {
            Debug.LogWarning("Inventory full");
            return false;
        }
    }

    public void Remove(Item item)
    {
        if(items.Contains(item))
        {
            items.Remove(item);
            if(onChange != null)
            {
                onChange.Invoke();
            }
        }
        else
        {
            Debug.LogWarning("Item not found");
        }
    }
    
}
