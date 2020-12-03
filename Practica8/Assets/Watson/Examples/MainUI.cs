using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    public Text playerHealth;
    public Text enemyHealth;
    public GameEntity gameState;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerHealth.text = gameState.GetPlayerHealth().ToString() + "/" + gameState.GetMaxPlayerHealth().ToString();
        enemyHealth.text = gameState.GetEnemyHealth().ToString() + "/" + gameState.GetMaxEnemyHealth().ToString();
    }

    public string EnableUI()
    {
        return "UI Enabled";
    }
    
    public string DisableUI()
    {
        return "UI Disabled";
    }
}
