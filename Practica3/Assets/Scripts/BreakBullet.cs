using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBullet : Bullet
{
    protected override void Start()
    {
        base.Start();
        bullet = GameObject.Find("Break Bullet");
    }

    public override void Interact()
    {
        base.Interact();
        Debug.Log("Break");
    }

    protected override void EnableInteract()
    {
        base.EnableInteract();
        MessageText[0].text = "<Break> Bullet";
    }
}
