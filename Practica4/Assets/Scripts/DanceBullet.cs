using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceBullet : Bullet
{
    protected override void Start()
    {
        base.Start();
        bullet = GameObject.Find("Dance Bullet");
    }

    public override void Interact()
    {
        base.Interact();
        Debug.Log("Dance");
    }

    protected override void EnableInteract()
    {
        base.EnableInteract();
        MessageText[0].text = "<Dance> Bullet";
    }
}
