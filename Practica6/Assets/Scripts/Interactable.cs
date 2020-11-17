using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    protected bool isInsideZone = false;
    public GameObject MessageUI;
    public Text[] MessageText;
    public Image icon;

    public float triggerInteractonTime = 2f;
    public float interactionTimer = 0f;
    private bool timerRunning = false;

    public virtual void Interact()
    {

    }

    void Update()
    {
        if(timerRunning)
        {
            interactionTimer += Time.deltaTime;
            if(interactionTimer > triggerInteractonTime)
            {
                Interact();
            }
        }
    }

    public void SetGazedAt(bool gazedAt)
    {
        // if(!isInsideZone)
        //     return;
        
        if(gazedAt)
        {
            Debug.Log("Gazed");
            EnableInteract();
            timerRunning = true;
        }
        else
        {
            DisableInteract();
            timerRunning = false;
            interactionTimer = 0f;
        }
    }

    protected virtual void EnableInteract()
    {
        // isInsideZone = true;
        MessageUI.SetActive(true);
    }

    protected virtual void DisableInteract()
    {
        // isInsideZone = false;
        MessageUI.SetActive(false);
    }
}