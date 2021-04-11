using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class GameController : MonoBehaviour
{

    [SerializeField] private GameObject blackBG;
    [SerializeField] private GameObject[] activityButtons;
    
    // Start is called before the first frame update
    void Start()
    {
        DeactivateActivityButtons();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndTextReplay() {
        blackBG.SetActive(false);
    }

    public void DeactivateGameObject(GameObject obj) {
        obj.SetActive(false);
    }

    public void ActivateActivityButtons() {
        for (int i = 0; i < activityButtons.Length; i++) {
            activityButtons[i].SetActive(true);
        }
    }

    public void DeactivateActivityButtons() {
        for (int i = 0; i < activityButtons.Length; i++) {
            activityButtons[i].SetActive(false);
        }
    }

    public void Scene2Transition_HouseButtonClicked() {
        Fungus.Flowchart.BroadcastFungusMessage ("start scene 3");
    }

    public void TriggerDefaultMapMessage() {
        Fungus.Flowchart.BroadcastFungusMessage ("default map message");
    }
}
