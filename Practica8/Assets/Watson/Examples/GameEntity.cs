using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEntity : MonoBehaviour
{
    public Pokemon player;
    public Pokemon enemy;
    private string dialogText;
    // Start is called before the first frame update
    void Start()
    {

    }

    public int GetPlayerHealth()
    {
        return player.GetHealth();
    }
    
    public int GetMaxPlayerHealth()
    {
        return player.GetMaxHealth();
    }
    
    public int GetEnemyHealth()
    {
        return enemy.GetHealth();
    }
    
    public int GetMaxEnemyHealth()
    {
        return enemy.GetMaxHealth();
    }

    public string GetDialogText()
    {
        return dialogText;
    }

    public void AttackRound()
    {
        dialogText = enemy.name + " receives damage!";
        if(enemy.ReceiveDamage())
        {
            dialogText = "Enemy " + enemy.name + " fainted!";
        }
        
        dialogText = player.name + " receives damage!";
        if(player.ReceiveDamage())
        {
            dialogText = "Enemy " + player.name + " fainted!";
        }
    }
}
