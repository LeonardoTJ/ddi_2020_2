using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public string name;

    public virtual int Use()
    {
        return 0;
    }
}
