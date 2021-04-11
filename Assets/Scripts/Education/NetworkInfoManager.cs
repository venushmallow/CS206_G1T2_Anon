using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class NetworkInfoManager : MonoBehaviour
{
    [SerializeField] private Text networkInfoText;
    [SerializeField] private GameObject networkInfoPanel;
    
    public void ToggleNetworkPanel() {
        networkInfoPanel.SetActive(true);
    }

    public void ChangeText(string text) {
        networkInfoText.text = text;
    }

    public void InfoButtonClicked() {
        string name = (string)EventSystem.current.currentSelectedGameObject.name;
        if (name == "Wireshark") {
            ChangeText("A common tool used for network analysis is <b>Wireshark</b>, a free and open-source packet analyzer.");
        } else if (name == "OSIModel") {
            ChangeText("The Open Systems Interconnection Model (OSI) is a conceptual framework used to describe the functions of a networking system.");
        }
    }
}
