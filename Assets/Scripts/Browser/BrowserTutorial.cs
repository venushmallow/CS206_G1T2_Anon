using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Fungus;

public class BrowserTutorial : MonoBehaviour
{

    [SerializeField] public Text searchBarText;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return)) { 
            processSearch();
        }
        // user type in query to the WebBrowser
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Fungus.Flowchart.BroadcastFungusMessage(searchBarText.text);
        }
    }

    public void processSearch() {
        string search = searchBarText.text;
        if (search.Contains("cafe") || search.Contains("food") || search.Contains("eat") || search.Contains("moonwich")) {
            Fungus.Flowchart.BroadcastFungusMessage ("find cafe");
        } else {
            Fungus.Flowchart.BroadcastFungusMessage("NILSearch");
        }
    }

    public void ReturnToTutorial() {
        SceneManager.LoadScene("Tutorial");
    }

    /*
public Fungus.Flowchart myFlowchart; // Link the Flowchart in your script

myFlowchart.ExecuteBlock(blockName); //call the block that handle Stay or Entry
    */
}
