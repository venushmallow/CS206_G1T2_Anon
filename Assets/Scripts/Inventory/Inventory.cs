using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> characterItems = new List<Item>();
    public ItemDatabase itemDatabase;
    public UIInventory inventoryUI;

    void Update() {
        if (inventoryUI.gameObject.activeSelf) {
            int slot = 0;
            foreach (Item item in characterItems) {
                inventoryUI.UpdateSlot(slot++, item);
            }
        }
    }

    // Method to give player an item with item ID
    public void GiveItem(int id) {
        Item itemToAdd = itemDatabase.GetItem(id);
        characterItems.Add(itemToAdd);
        inventoryUI.AddNewItem(itemToAdd);
        // Debug.Log("Added item: " + itemToAdd.title);
    }

    // Method to give player an item with item name
    public void GiveItem(string itemName) {
        Item itemToAdd = itemDatabase.GetItem(itemName);
        characterItems.Add(itemToAdd);
        Debug.Log("Item added to Inventory");
    }

    // Method to check if player's inventory contains specific item
    public Item CheckForItem(int id) {
        return characterItems.Find(item => item.id == id);
    }

    // Method to delete player's inventory items
    public void RemoveItem(int id) {
        Item item = CheckForItem(id);
        if (item != null) {
            characterItems.Remove(item);
            // Debug.Log("Item removed: " + item.title);
        }
    }
}
