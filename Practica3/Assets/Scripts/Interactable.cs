﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    bool isInsideZone = false;
    // Start is called before the first frame update
    public virtual void Interact()
    {
        Debug.Log("Interactuando");
    }

    void Update()
    {
        if(isInsideZone && Input.GetKeyDown(KeyCode.I))
        {
            Interact();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(!other.CompareTag("Player"))
        {
            return;
        }
        isInsideZone = true;
    }

    void OnTriggerExit(Collider other)
    {
        if(!other.CompareTag("Player"))
        {
            return;
        }
        isInsideZone = false;
    }
}
