using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : Bullet
{
    public override void Interact()
    {
        base.Interact();
        Debug.Log("Move");
    }
}
