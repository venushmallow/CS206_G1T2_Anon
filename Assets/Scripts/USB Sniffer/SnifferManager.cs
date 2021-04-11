using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Fungus;

public class SnifferManager : MonoBehaviour
{
    [SerializeField] private GameObject searchBar;
    [SerializeField] private Text searchBarText;
    [SerializeField] private GameObject connectingScreen;
    [SerializeField] private GameObject trafficScreen;
    [SerializeField] private GameObject packets;
    [SerializeField] private Flowchart flowchart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            activatePasswordPacketSimulation();
        }
    }

    public void activatePasswordPacketSimulation()
    {
        Fungus.Flowchart.BroadcastFungusMessage("PasswordStart");
    }

    public void showPackets()
    {
        packets.SetActive(!packets.activeSelf);
    }

    public void activateSearchBar()
    {
        searchBar.SetActive(!searchBar.activeSelf);
    }

    public void showConnecting()
    {
        connectingScreen.SetActive(!connectingScreen.activeSelf);
    }

    //public void showTraffic()
    //{
    //    Debug.Log("showtraffic");
    //    trafficScreen.SetActive(!trafficScreen.activeSelf);
    //}

    public void ReturnToScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
