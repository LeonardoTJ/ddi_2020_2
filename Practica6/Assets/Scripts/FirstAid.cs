using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAid : PickupObject
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
}
