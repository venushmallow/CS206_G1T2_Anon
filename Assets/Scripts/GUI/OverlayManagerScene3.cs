using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class OverlayManagerScene3 : MonoBehaviour
{

    //[SerializeField] private GameObject inventoryPanel;
    [SerializeField] private GameObject desktopPanel;
    [SerializeField] private GameObject mobilePanel;
    [SerializeField] private GameObject helpinfo;
    [SerializeField] private GameObject exit;

    [SerializeField] private Flowchart tutorialFlowchart;

    [SerializeField] private GameObject Justin;

    // General toggling
    public void ToggleOn(GameObject activatePanel) {
        activatePanel.SetActive(true);
    }

    public void ToggleOff(GameObject deactivatePanel) {
        deactivatePanel.SetActive(false);
    }

    public void showJustin()
    {
        Justin.SetActive(!Justin.activeSelf);
    }

    // Network button

    public void LoadNetwork3_1() {
        Fungus.Flowchart.BroadcastFungusMessage ("OpenNetwork3_1");
    }

    public void LoadNetwork3_2() {
        Fungus.Flowchart.BroadcastFungusMessage ("OpenNetwork3_2");
    }

    // Toggles desktop
    public void ToggleDesktop()
    {
        desktopPanel.SetActive(!desktopPanel.activeSelf);
    }

    // Loads new web browser scene
    public void OpenWebBrowser()
    {
        Debug.Log("open browser");
        SceneManager.LoadScene("Browser-Scene3");
    }

    // Toggle info
    public void openInfo()
    {
        Debug.Log("open info");
        helpinfo.SetActive(!helpinfo.activeSelf);
    }

    // Toggles map panel
    public void ToggleMobile()
    {
        mobilePanel.SetActive(!mobilePanel.activeSelf);
        desktopPanel.SetActive(false);
    }

    public void activateExit()
    {
        exit.SetActive(!exit.activeSelf);
    }

    // for loading scenes - input scene name manually
    public void loadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
