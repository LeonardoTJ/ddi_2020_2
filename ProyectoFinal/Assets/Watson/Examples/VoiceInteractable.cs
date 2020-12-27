using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VoiceInteractable : MonoBehaviour
{
    private VoiceCommandProcessor commandProcessor;
    public int book_id;
    public Text uiText;

    void Start()
    {
        // commandProcessor = VoiceCommandProcessor.Instance;
        // commandProcessor.onVoiceCommand += VoiceInteract;
    }

    void OnEnable()
    {
        // commandProcessor.SetActions(Book.LINKS[book_id].Keys);
    }
    
    void OnDisable()
    {
        // commandProcessor.SetActions(null);
    }

    public virtual void VoiceInteract(string command)
    {
        string url = "";
        if (Book.LINKS[book_id].TryGetValue(command, out url))
        {
            uiText.text = "Reconocido: " + Book.TITLES[book_id];
            Application.OpenURL(url);
        }
        else
        {
            uiText.text = "No se encontró el contenido.";
        }
    }
}
