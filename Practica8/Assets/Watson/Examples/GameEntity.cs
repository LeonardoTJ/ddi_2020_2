using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEntity : MonoBehaviour
{
    public Pokemon player;
    public Pokemon enemy;
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

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool AttackRound()
    {
        return (enemy.ReceiveDamage() || player.ReceiveDamage());
    }
}
