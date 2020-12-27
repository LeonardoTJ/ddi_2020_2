﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;

public class VoiceCommandProcessor : MonoBehaviour
{
    static protected VoiceCommandProcessor s_VoiceInstance;
    private VoiceCommandProcessor commandProcessor;
    public delegate void OnVoiceCommand(string action);
    public OnVoiceCommand onVoiceCommand;
    private int currentBookId;
    private Dictionary<string, string>.KeyCollection actions;
    public Text uiText;

    void Awake()
    {
        s_VoiceInstance = this;
    }

    public void SetActions(Dictionary<string, string>.KeyCollection actions)
    {
        this.actions = actions;
    }

    public string[] GetActions()
    {
        if(actions != null)
        {
            string[] a = new string[actions.Count];
            ((ICollection)actions).CopyTo(a, 0);
            return a;
        }
        return null;
    }

    public void SetCurrentBookId(int id)
    {
        currentBookId = id;
    }
    
    static public VoiceCommandProcessor Instance{
        get{
            return s_VoiceInstance;
        }
    }

    public void Create(string transcript)
    {
        transcript = transcript.Trim();
        
        if (actions != null)
        {
            foreach(var action in actions)
            {
                if(action.Equals(transcript))
                {
                    Debug.Log("<<<<Reconocido>>>> Transcription: " + transcript + "\nAction: " + action);
                    string url = "";
                    if (Book.LINKS[currentBookId].TryGetValue(transcript, out url))
                    {
                        string chapNum = url.Substring(url.Length-2, 2);
                        string chapTitle = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(transcript);
                        uiText.text = "Reconocido: " + Book.TITLES[currentBookId] + "\nCapítulo " + Int32.Parse(chapNum) + ": " + chapTitle;
                        Application.OpenURL(url);
                    }
                    return;
                }
            }
            uiText.text = "No se encontró el contenido.\n" + transcript;
        }
    }
}
