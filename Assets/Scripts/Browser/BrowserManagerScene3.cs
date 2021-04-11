using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Fungus;

public class BrowserManagerScene3 : MonoBehaviour
{

    [SerializeField] public Text searchBarText;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return)) { 
            processSearch();
        }
    }

    public void processSearch() {
        string search = searchBarText.text.ToLower();
        if(search.Contains("maltego"))
        {
            Fungus.Flowchart.BroadcastFungusMessage("maltego");
        }
        else if(search.Contains("namechk"))
        {
            Fungus.Flowchart.BroadcastFungusMessage("namechk");
        }
        else if (search.Contains("hack usb") || search.Contains("how to hack an usb") || search.Contains("usb hack"))
        {
            Fungus.Flowchart.BroadcastFungusMessage("hack usb");
        }
        else if(search.Contains("usb sniffer"))
        {
            Fungus.Flowchart.BroadcastFungusMessage("usb sniffer");
        }
        else
        {
            Fungus.Flowchart.BroadcastFungusMessage("noresultsfound");
        }
    } 

    public void ReturnToScene(string scene) {
        SceneManager.LoadScene(scene);
    }

    /*
public Fungus.Flowchart myFlowchart; // Link the Flowchart in your script

myFlowchart.ExecuteBlock(blockName); //call the block that handle Stay or Entry
    */
}
