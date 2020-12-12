using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceCommandProcessor : MonoBehaviour
{
    static protected VoiceCommandProcessor s_VoiceInstance;
    private VoiceCommandProcessor commandProcessor;
    public delegate void OnVoiceCommand(string action);
    public OnVoiceCommand onVoiceCommand;
    public List<string> actions;
    
    void Awake()
    {
        s_VoiceInstance = this;
    }

    void Start()
    {
        
    }
    
    static public VoiceCommandProcessor Instance{
        get{
            return s_VoiceInstance;
        }
    }

    public void Create(string transcript)
    {
        string[] words = transcript.Split(' ');

        foreach(var word in words)
        {
            if(actions.Contains(word.ToLower()))
            {
                if(onVoiceCommand != null)
                {
                    onVoiceCommand.Invoke(word);
                }
                return;
            }
            
        }
    }
}
