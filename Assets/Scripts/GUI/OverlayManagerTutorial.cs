using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class OverlayManagerTutorial : MonoBehaviour
{

    [SerializeField] private GameObject inventoryPanel;
    [SerializeField] private GameObject desktopPanel;
    [SerializeField] private GameObject mobilePanel;

    [SerializeField] private Flowchart tutorialFlowchart;
    [SerializeField] private GameObject newMapLocation;

    void Update() {
        // Check if user found new map location
        bool cafeFound = tutorialFlowchart.GetBooleanVariable("cafeFound");
        if (cafeFound) {
            newMapLocation.SetActive(true);
        }
    }

    // Network button
    public void NetworkButtonPressed() {
        Fungus.Flowchart.BroadcastFungusMessage ("NoNetwork");
    }

    // Toggles inventory
    public void ToggleInventory() {
        inventoryPanel.SetActive(!inventoryPanel.activeSelf);
    }

    // Toggles desktop
    public void ToggleDesktop() {
        desktopPanel.SetActive(!desktopPanel.activeSelf);
    }

    // Loads new web browser scene
    public void OpenWebBrowser() {
        SceneManager.LoadScene("BrowserTutorial");
    }

    // Toggles map panel
    public void ToggleMobile() {
        mobilePanel.SetActive(!mobilePanel.activeSelf);
    }

    // for loading scenes - input scene name manually
    public void loadScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }
    
}
