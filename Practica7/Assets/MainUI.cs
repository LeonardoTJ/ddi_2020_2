using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    private bool battleMode;
    public GameObject UIObject;
    public Text enemyHealth;
    public Entity enemy;
    public Text playerHealth;
    public Entity player;
    
    // Start is called before the first frame update
    void Start()
    {
        battleMode = false;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateEnemyHealth();
        UpdatePlayerHealth();
    }

    public bool IsInBattle()
    {
        return battleMode;
    }

    public void StartBattleMode()
    {
        battleMode = true;
        UIObject.SetActive(true);
    }
    
    public void EndBattleMode()
    {
        battleMode = false;
        UIObject.SetActive(false);
    }

    public void UpdateEnemyHealth()
    {
        enemyHealth.text = enemy.GetHealth().ToString() + " HP";
    }
    
    public void UpdatePlayerHealth()
    {
        playerHealth.text = player.GetHealth().ToString() + " HP";
    }
}
