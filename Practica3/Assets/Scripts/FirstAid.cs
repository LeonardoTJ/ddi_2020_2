using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAid : Interactable
{
    Rigidbody rb;
    public float torque;

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
        Debug.Log("Recogiendo salud");
    }
}
