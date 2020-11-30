using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    private bool battleMode;
    public GameObject UIObject;
    public Text enemyHealth;
    // public List<Entity> enemies;
    private Entity currentEnemy;
    public Text playerHealth;
    public Entity player;

    public Image weaponIcon;
    public Text weaponName;
    
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

    public void StartBattleMode(Entity enemy)
    {
        currentEnemy = enemy;
        weaponIcon.sprite = enemy.weaponIcon;
        weaponName.text = enemy.weaponName;
        battleMode = true;
        UIObject.SetActive(true);
    }
    
    public void EndBattleMode()
    {
        currentEnemy = null;
        battleMode = false;
        UIObject.SetActive(false);
    }

    public void UpdateEnemyHealth()
    {
        if(currentEnemy != null)
            enemyHealth.text = currentEnemy.GetHealth().ToString() + " HP";
    }
    
    public void UpdatePlayerHealth()
    {
        playerHealth.text = player.GetHealth().ToString() + " HP";
    }
}
