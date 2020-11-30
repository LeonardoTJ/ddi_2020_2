using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARInteraction : MonoBehaviour
{
    public MainUI mainUI;
    public Entity enemy;

    void OnMouseDown()
    {
        Debug.Log("Interact");
        if(!mainUI.IsInBattle())
        {
            mainUI.StartBattleMode(enemy);
        }
        else
        {
            if(enemy.ReceiveAttack())
            {
                mainUI.EndBattleMode();
                Destroy(this.gameObject);
            }
        }
    }
}