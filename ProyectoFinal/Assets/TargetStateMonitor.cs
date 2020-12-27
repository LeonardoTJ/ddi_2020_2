using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TargetStateMonitor : MonoBehaviour, ITrackableEventHandler 
{
    private TrackableBehaviour mTrackableBehaviour;
    private VoiceCommandProcessor commandProcessor;
    public int book_id;
    

    void Start()
    {
        commandProcessor = VoiceCommandProcessor.Instance;
        // commandProcessor.onVoiceCommand += VoiceInteract;
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    { 
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            OnTrackingFound();
        }
        else if (previousStatus == TrackableBehaviour.Status.TRACKED &&
                 newStatus == TrackableBehaviour.Status.NO_POSE)
        {
            OnTrackingLost();
        }
    }

    private void OnTrackingFound()
    {
        commandProcessor.SetCurrentBookId(book_id);
        commandProcessor.SetActions(Book.LINKS[book_id].Keys);
        string actions = "Cambiando acciones a:\n";
        foreach(var a in commandProcessor.GetActions())
        {
            actions += a + "\n";
        }
        Debug.Log(actions);
    }

    private void OnTrackingLost()
    {
        commandProcessor.SetActions(null);
        Debug.Log("Cambiando acciones a null");
    }
}
