using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListItemController : MonoBehaviour
{
    public Text uiText;
    public string url;
    
    public void OnChapterClick()
    {
        if(url != null)
        {
            Application.OpenURL(url);
        }
    }
}
