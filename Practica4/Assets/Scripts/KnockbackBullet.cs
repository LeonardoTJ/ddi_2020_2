using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockbackBullet : Bullet
{
    protected override void Start()
    {
        base.Start();
        bullet = GameObject.Find("Knockback Bullet");
    }

    public override void Interact()
    {
        base.Interact();
        Debug.Log("Knockback");
    }

    protected override void EnableInteract()
    {
        base.EnableInteract();
        MessageText[0].text = "<Knockback> Bullet";
    }
}
