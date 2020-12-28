using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;

public class ListController : MonoBehaviour
{
    public GameObject ContentPanel;
    public GameObject ListItemPrefab;

    public void SetupList(int bookId)
    {
        GameObject newListItem = Instantiate(ListItemPrefab) as GameObject;
        ListItemController controller = newListItem.GetComponent<ListItemController>();
        controller.uiText.text = Book.TITLES[bookId] + ", " + Book.AUTHORS[bookId] + "\n";

        newListItem.transform.parent = ContentPanel.transform;
        newListItem.transform.localScale = Vector3.one;
        
        newListItem = Instantiate(ListItemPrefab) as GameObject;
        controller = newListItem.GetComponent<ListItemController>();
        controller.uiText.text = Book.DATES[bookId] + ", " + Book.LANGUAGES[bookId];

        newListItem.transform.parent = ContentPanel.transform;
        newListItem.transform.localScale = Vector3.one;

        foreach(KeyValuePair<string, string> kvp in Book.LINKS[bookId]){
            string chapNum = kvp.Value.Substring(kvp.Value.Length-2, 2);
            string chapTitle = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(kvp.Key);

            newListItem = Instantiate(ListItemPrefab) as GameObject;
            controller = newListItem.GetComponent<ListItemController>();
            controller.uiText.text = "Capítulo " + Int32.Parse(chapNum) + ": " + chapTitle;
            controller.url = kvp.Value;

            newListItem.transform.parent = ContentPanel.transform;
            newListItem.transform.localScale = Vector3.one;
        }
    }

    public void ResetList()
    {
        if(transform.GetChild(0).childCount <= 1)
            return;

        int i = 0;
        GameObject[] allChildren = new GameObject[transform.GetChild(0).childCount];

        
        foreach (Transform child in transform.GetChild(0))
        {
            allChildren[i] = child.gameObject;
            i += 1;
        }

        foreach (GameObject child in allChildren)
        {
            DestroyImmediate(child.gameObject);
        }
    }
}
