using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : Interactable
{
    public override void Interact()
    {
        base.Interact();
        Debug.Log("Recogiendo bala");
    }
}
