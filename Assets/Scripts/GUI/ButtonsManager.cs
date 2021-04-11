using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsManager : MonoBehaviour
{

    [SerializeField] private GameObject readPanel;

    public void DeactivateParent() {
        transform.parent.gameObject.SetActive(!transform.parent.gameObject.activeSelf);
    }

    public void ReadButton() {
        readPanel.SetActive(true);
    }
}
