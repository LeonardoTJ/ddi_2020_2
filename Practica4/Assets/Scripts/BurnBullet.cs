using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnBullet : Bullet
{
    protected override void Start()
    {
        base.Start();
        bullet = GameObject.Find("Burn Bullet");
    }

    public override void Interact()
    {
        base.Interact();
        Debug.Log("Burn");
    }

    protected override void EnableInteract()
    {
        base.EnableInteract();
        MessageText[0].text = "<Burn> Bullet";
    }
}
