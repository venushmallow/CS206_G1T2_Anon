using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clickable : MonoBehaviour
{

    public Inventory inventory;
    public ItemDatabase itemDatabase;
    private GameObject player;
    
    private Vector2 targetPos;
    [SerializeField] private Text clickableText;

    void Start() {
        player = GameObject.Find("Player");
    }

    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            DetectPickupClicked();
        }
    }

    void DetectPickupClicked() {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider != null)
            {
                if (hit.collider.gameObject.tag == "Clickable") {
                    ProcessInventory(hit.collider.gameObject.name);
                    Destroy(hit.collider.gameObject);
                    clickableText.gameObject.SetActive(false);
                }
            }
        }
    }

    void ProcessInventory(string itemName) {
        // add to inventory
        inventory.GiveItem(itemName);
    }

    void OnMouseOver() {
        clickableText.gameObject.SetActive(true);
        clickableText.text = this.name;
        clickableText.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y - 50, clickableText.transform.position.z);
    }

    void OnMouseExit() {
        clickableText.gameObject.SetActive(false);
    }
}
