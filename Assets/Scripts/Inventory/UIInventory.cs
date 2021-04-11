using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// UI Inventory: keep track of all UI Items and determine which ones are visible or not, and where they are
public class UIInventory : MonoBehaviour
{
    public List<UIItem> uiItems = new List<UIItem>();
    public GameObject slotPrefab;
    public Transform slotPanel;
    public int numberOfSlots = 8;

    public Inventory inventory;

    // create as many slots as needed to fill inventory
    private void Awake() {
        for (int i = 0; i < numberOfSlots; i++) {
            GameObject instance = Instantiate(slotPrefab);
            instance.transform.SetParent(slotPanel);
            uiItems.Add(instance.GetComponentInChildren<UIItem>());
        }
    }

    // show or hide items
    public void UpdateSlot(int slot, Item item) {
        uiItems[slot].UpdateItem(item);
    }

    // add a new item - insert at first empty slot
    public void AddNewItem(Item item) {
        UpdateSlot(uiItems.FindIndex(i => i.item == null), item);
    }

    // remove item
    public void RemoveItem(Item item) {
        UpdateSlot(uiItems.FindIndex(i => i.item == item), null);
    }
}
