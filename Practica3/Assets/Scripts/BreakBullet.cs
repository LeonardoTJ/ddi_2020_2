using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBullet : Bullet
{
    public override void Interact()
    {
        base.Interact();
        Debug.Log("Break");
    }
}
