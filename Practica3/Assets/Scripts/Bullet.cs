﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : Interactable
{
    protected GameObject bullet;
    public override void Interact()
    {
        base.Interact();
        Debug.Log("Bullet Pickup");
        bullet.SetActive(false);
        DisableInteract();
    }
}
