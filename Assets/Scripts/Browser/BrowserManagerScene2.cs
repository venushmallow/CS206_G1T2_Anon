using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Fungus;

public class BrowserManagerScene2 : MonoBehaviour
{

    [SerializeField] private Text searchBarText;
    [SerializeField] private GameObject returnButton;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return)) { 
            processSearch();
        }
    }

    public void processSearch() {
        string search = searchBarText.text.ToLower();

        if (search.Contains("license plate") || search.Contains("mw1670") || search.Contains("mw 1670")) {
            Fungus.Flowchart.BroadcastFungusMessage("mw1670");
        } else if (search.Contains("security camera")) {
            Fungus.Flowchart.BroadcastFungusMessage("security camera");
        } else if (search.Contains("07890")) {
            Fungus.Flowchart.BroadcastFungusMessage("postcode");
        } else if (search.Contains("land registry")) {
            Fungus.Flowchart.BroadcastFungusMessage("find artemis home");
        } else if (search.Contains("artemis home") || search.Contains("artemis house")) {
            Fungus.Flowchart.BroadcastFungusMessage("easy search");
        } else if (search.Contains("argus communications")) {
            Fungus.Flowchart.BroadcastFungusMessage("begin shodan"); // bridge not yet created
        } else if (search.Contains("jacob williams")) {
            Fungus.Flowchart.BroadcastFungusMessage("find car owner");
        } else if (search.Contains("lighthouse")) {
            Fungus.Flowchart.BroadcastFungusMessage("lighthouse");
        } else if (search.Contains("1670")) {
            Fungus.Flowchart.BroadcastFungusMessage("1670");
        } else {
            Fungus.Flowchart.BroadcastFungusMessage ("NILSearch");
        }
        
    }

    public void ActivateReturnButton() {
        returnButton.SetActive(true);
    }

    public void ReturnToScene(string scene) {
        SceneManager.LoadScene(scene);
    }

    /*
public Fungus.Flowchart myFlowchart; // Link the Flowchart in your script

myFlowchart.ExecuteBlock(blockName); //call the block that handle Stay or Entry
    */
}
