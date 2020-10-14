using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : Bullet
{
    protected override void Start()
    {
        base.Start();
        bullet = GameObject.Find("Move Bullet");
    }

    public override void Interact()
    {
        base.Interact();
        Debug.Log("Move Bullet");
    }

    protected override void EnableInteract()
    {
        base.EnableInteract();
        MessageText[0].text = "<Move> Bullet";
    }
}
