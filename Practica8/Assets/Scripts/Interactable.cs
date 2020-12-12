using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    // protected bool isInsideZone = false;
    // public GameObject MessageUI;
    // public Text[] MessageText;
    // public Image icon;

    public virtual void Interact()
    {

    }

    void Update()
    {

    }

    // void OnTriggerEnter(Collider other)
    // {
    //     if(!other.CompareTag("Player"))
    //     {
    //         return;
    //     }
    //     EnableInteract();
    // }

    // void OnTriggerExit(Collider other)
    // {
    //     if(!other.CompareTag("Player"))
    //     {
    //         return;
    //     }
    //     DisableInteract();
    // }

    // protected virtual void EnableInteract()
    // {
    //     isInsideZone = true;
    //     MessageUI.SetActive(true);
    // }

    // protected virtual void DisableInteract()
    // {
    //     isInsideZone = false;
    //     MessageUI.SetActive(false);
    // }
}