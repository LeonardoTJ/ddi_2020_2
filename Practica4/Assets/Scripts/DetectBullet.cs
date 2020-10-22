using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectBullet : Bullet
{
    protected override void Start()
    {
        base.Start();
        bullet = GameObject.Find("Detect Bullet");
    }

    public override void Interact()
    {
        base.Interact();
        Debug.Log("Detect");
    }

    protected override void EnableInteract()
    {
        base.EnableInteract();
        MessageText[0].text = "<Detect> Bullet";
    }
}
