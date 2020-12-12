using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEntity : MonoBehaviour
{
    static protected GameEntity gameInstance;
    public Pokemon player;
    public Pokemon reserve;
    public Pokemon enemy;
    private string dialogText;
    public MainUI ui;

    void Awake()
    {
        gameInstance = this;
        ui = MainUI.Instance;
    }

    static public GameEntity Instance{
        get{
            return gameInstance;
        }
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
            ui.RemoveEnemy();
        }
        
        dialogText = player.name + " receives damage!";
        if(player.ReceiveDamage())
        {
            dialogText = "Player " + player.name + " fainted!";
            ui.RemovePlayer();
        }
    }

    public void SwitchPokemon()
    {
        Pokemon temp;
        temp = player;
        player = reserve;
        reserve = temp;
        ui.SwitchPokemonUI();
    }

    public void UseItem()
    {
        
    }

}
