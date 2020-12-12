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
    public Stack<Item> items;

    void Awake()
    {
        gameInstance = this;
        ui = MainUI.Instance;
        items = new Stack<Item>();
        for(int i = 0; i<5; i++)
        {
            items.Push(new Potion());
        }
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
        if(items.Count > 0)
            player.Heal(items.Pop().Use());
        else
            Debug.Log("No hay items");

        dialogText = player.name + " heals!";
    }

    public void Run()
    {
        ui.DisableUI();
    }

}
