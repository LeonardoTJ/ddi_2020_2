using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalyzeBullet : Bullet
{
    protected override void Start()
    {
        base.Start();
        bullet = GameObject.Find("Paralyze Bullet");
    }

    public override void Interact()
    {
        base.Interact();
        Debug.Log("Paralyze");
    }

    protected override void EnableInteract()
    {
        base.EnableInteract();
        MessageText[0].text = "<Paralyze> Bullets";
    }
}
