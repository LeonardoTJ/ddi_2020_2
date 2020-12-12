using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    static protected MainUI uiInstance;
    public Text playerHealth;
    public Text enemyHealth;
    public Text dialogPanelText;
    
    public GameObject playerPokemon;
    public GameObject playerPokemonStatus;
    public GameObject enemyPokemon;
    public GameObject enemyPokemonStatus;
    public GameObject reservePokemon;
    public GameObject reservePokemonStatus;
    
    public GameEntity gameState;

    void Awake()
    {
        uiInstance = this;
    }

    static public MainUI Instance{
        get{
            return uiInstance;
        }
    }

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
    
    public void RemoveEnemy()
    {
        enemyPokemon.SetActive(false);
        enemyPokemonStatus.SetActive(false);
    }
    
    public void RemovePlayer()
    {
        playerPokemonStatus.SetActive(false);
    }

    public void SwitchPokemonUI()
    {
        GameObject temp = playerPokemonStatus;
        playerPokemonStatus = reservePokemonStatus;
        reservePokemonStatus = temp;
        playerPokemon.SetActive(false);
        reservePokemon.SetActive(true);
    }
    
}
