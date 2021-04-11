using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Fungus;

public class BrowserManager : MonoBehaviour
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

        if (search.Contains("artemis moonwich") || search.Contains("artemis moonwich bay") || search.Contains("artemis in moonwich bay") || search.Contains("artemis at moonwich bay")) {
            Fungus.Flowchart.BroadcastFungusMessage("find artemis");
        }
        else if (search.Contains("artemis"))
        {
            // broad search
            Fungus.Flowchart.BroadcastFungusMessage("general artemis");
        }
        else if(search.Contains("moonbar manager") || search.Contains("moonwich manager") || search.Contains("miranda manager") || search.Contains("manager miranda") || search.Contains("miranda moonwich")) {
            Fungus.Flowchart.BroadcastFungusMessage("find manager");
        }
        else if (search.Contains("manager"))
        {
            // broad search
            Fungus.Flowchart.BroadcastFungusMessage("general manager");
        }
        else if (search.Contains("justin sayers moonwich bay") || search.Contains("justin sayers in moonwich bay")) {
            Fungus.Flowchart.BroadcastFungusMessage("justin's mw history");
        }
        else if (search.Contains("justin garage mechanic") || search.Contains("mechanic") || search.Contains("garage") || search.Contains("justin moonwich")) {
            Fungus.Flowchart.BroadcastFungusMessage("find justin's workplace");
        } 
        else if (search.Contains("justin sayers site:faceplace.com") || search.Contains("justin sayers garibaldi")) {
            Fungus.Flowchart.BroadcastFungusMessage("find justin's social media");
        }
        else if (search.Contains("narrow down search for social media account") || search.Contains("terms to narrow down") || search.Contains("narrow terms") || search.Contains("narrow down")) {
            Fungus.Flowchart.BroadcastFungusMessage("google dorking");
        }
        else if (search.Contains("justin sayers")) {
            // broad search
            Fungus.Flowchart.BroadcastFungusMessage("find justin's namesakes");
        }
        else if (search.Contains("business directory")) {
            // business directory
            Fungus.Flowchart.BroadcastFungusMessage("find businesses");
        }
        else if (search.Contains("justin")) {
            Fungus.Flowchart.BroadcastFungusMessage("broad search for justin");
        }
        else if (search.Contains("username tool") || search.Contains("username lookup") || search.Contains("find username")) {
            Fungus.Flowchart.BroadcastFungusMessage("username correlation");
        }
        else if (search.Contains("jsayers00") || search.Contains("@jsayers00")) {
            Fungus.Flowchart.BroadcastFungusMessage("jsayers00");
        }
        else {
            Fungus.Flowchart.BroadcastFungusMessage ("NILSearch");
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
