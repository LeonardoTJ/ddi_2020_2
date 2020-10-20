using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryUIpanel;
    // Start is called before the first frame update
    void Start()
    {
        inventoryUIpanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            inventoryUIpanel.SetActive(!inventoryUIpanel.activeSelf);
        }
    }
}
