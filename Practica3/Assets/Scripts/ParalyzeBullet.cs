using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalyzeBullet : Bullet
{
    public override void Interact()
    {
        base.Interact();
        Debug.Log("Paralyze");
    }
}
