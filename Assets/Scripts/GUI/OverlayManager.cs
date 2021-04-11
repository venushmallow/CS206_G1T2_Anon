using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class OverlayManager : MonoBehaviour
{

    [SerializeField] private GameObject inventoryPanel;
    [SerializeField] private GameObject desktopPanel;
    [SerializeField] private GameObject mobilePanel;
    [SerializeField] private GameObject infoPanel;
    [SerializeField] private GameObject socialPanel;
    [SerializeField] private GameObject profileImage;
    [SerializeField] private GameObject lighthouseClickable;

    // Specific to tutorial - modify in other scenes or remove entirely
    private bool toggledLaptopForTheFirstTime = false;

    void Start() {
        // Specific to tutorial - modify in other scenes or remove entirely
        toggledLaptopForTheFirstTime = false;
    }

    // public void TogglePanel(GameObject panel) {
    //     panel.SetActive(!panel.activeSelf);
    // }

    public void ToggleOn(GameObject activatePanel) {
        activatePanel.SetActive(true);
    }

    public void ToggleOff(GameObject deactivatePanel) {
        deactivatePanel.SetActive(false);
    }

    public void ToggleInventory() {
        inventoryPanel.SetActive(!inventoryPanel.activeSelf);
    }

    public void ToggleDesktop() {

        // Specific to tutorial - modify in other scenes or remove entirely
        if (!toggledLaptopForTheFirstTime) {
            toggledLaptopForTheFirstTime = true;
            Fungus.Flowchart.BroadcastFungusMessage ("LaptopClicked");
        }

        desktopPanel.SetActive(!desktopPanel.activeSelf);
    }

    public void ToggleMobile() {
        mobilePanel.SetActive(!mobilePanel.activeSelf);
    }

    public void ToggleSocial() {
        socialPanel.SetActive(!socialPanel.activeSelf);
        desktopPanel.SetActive(false);
    }
        
    public void ToggleInformation() {
        infoPanel.SetActive(!infoPanel.activeSelf);
    }
    
    public void ToggleProfileImage() {
        profileImage.SetActive(!profileImage.activeSelf);
        Fungus.Flowchart.BroadcastFungusMessage("find lighthouse");
    }

    public void LoadNetwork() {
        Fungus.Flowchart.BroadcastFungusMessage ("OpenNetwork");
    }

    public void LoadNetwork2() {
        Fungus.Flowchart.BroadcastFungusMessage ("OpenNetwork2");
    }

    // for loading scenes - input scene name manually
    public void loadScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }

    public void SetLighthouseClickable() {
        lighthouseClickable.SetActive(true);
    }

    public void LighthouseClicked() {
        Fungus.Flowchart.BroadcastFungusMessage ("check level1-scene1 status");
    }

    void Awake() {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Persistent");

        for (int i = 0; i < objs.Length; i++) {
            DontDestroyOnLoad(objs[i]);
        }

    }

    
}
