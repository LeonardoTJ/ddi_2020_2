using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAid : Interactable
{
    Rigidbody rb;
    public float torque;
    GameObject kit;

    protected override void Start()
    {
        base.Start();
        kit = GameObject.Find("FirstAidKit_Red");
    }

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddTorque(transform.up * torque * -1);
    }

    public override void Interact()
    {
        base.Interact();
        Debug.Log("Health item interaction");
        kit.SetActive(false);
        DisableInteract();
    }

    protected override void EnableInteract()
    {
        base.EnableInteract();
        MessageText[0].text = "Health Item";
    }
}
