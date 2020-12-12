using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceInteractable : MonoBehaviour
{
    private VoiceCommandProcessor commandProcessor;
    public GameEntity game;

    void Start()
    {
        commandProcessor = VoiceCommandProcessor.Instance;
        commandProcessor.onVoiceCommand += VoiceInteract;
        game = GameEntity.Instance;
    }

    public virtual void VoiceInteract(string action)
    {
        Debug.Log("Interactuando: ");

        switch (action)
        {
            case "fights": game.AttackRound();
                            break;
            case "shift":  Debug.Log("Cambiando pokemon");
                            game.SwitchPokemon();
                            break;
            case "bag":    Debug.Log("Usando item");
                            game.UseItem();
                            break;
            case "run":    Debug.Log("Escapando");
                            break;
        }
    }
}
