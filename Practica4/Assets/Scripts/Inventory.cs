using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public delegate void OnChange();
    public OnChange onChange;
    public int space = 9;
    public int health = 2;
    public int energy = 1;
    public List<Item> items = new List<Item>();

    public bool isFull()
    {
        return items.Count >= space;
    }

    public bool Add(Item item)
    {
        if(!isFull())
        {
            item.Use();
            items.Add(item);
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
