using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    public Text playerHealth;
    public Text enemyHealth;
    public Text dialogPanelText;
    public GameEntity gameState;

    // Update is called once per frame
    void Update()
    {
        playerHealth.text = gameState.GetPlayerHealth().ToString() + "/" + gameState.GetMaxPlayerHealth().ToString();
        enemyHealth.text = gameState.GetEnemyHealth().ToString() + "/" + gameState.GetMaxEnemyHealth().ToString();
        dialogPanelText.text = gameState.GetDialogText();
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
