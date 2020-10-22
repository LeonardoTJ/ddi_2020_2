using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkBullet : Bullet
{
    protected override void Start()
    {
        base.Start();
        bullet = GameObject.Find("Link Bullet");
    }

    public override void Interact()
    {
        base.Interact();
        Debug.Log("Link");
    }

    protected override void EnableInteract()
    {
        base.EnableInteract();
        MessageText[0].text = "<Link> Bullet";
    }
}
