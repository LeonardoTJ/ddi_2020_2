using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceCommandProcessor : MonoBehaviour
{
    static protected VoiceCommandProcessor s_VoiceInstance;
    private VoiceCommandProcessor commandProcessor;
    public delegate void OnVoiceCommand(string action);
    public OnVoiceCommand onVoiceCommand;
    private Dictionary<string, string>.KeyCollection actions;

    void Awake()
    {
        s_VoiceInstance = this;
    }

    public void SetActions(Dictionary<string, string>.KeyCollection actions)
    {
        this.actions = actions;
    }
    
    static public VoiceCommandProcessor Instance{
        get{
            return s_VoiceInstance;
        }
    }

    public void Create(string transcript)
    {
        string[] words = transcript.Split(' ');

        if (actions != null)
        {
            foreach(var word in words)
            {
                if(((ICollection<string>)actions).Contains(word.ToLower()))
                {
                    if(onVoiceCommand != null)
                    {
                        onVoiceCommand.Invoke(word.ToLower());
                    }
                    return;
                }
                
            }
        }
    }
}
