using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> items = new List<Item>();
    private List<Object> clickables = new List<Object>();

    void Awake() {
        BuildDatabase();
    }

    void Start() {
        Object[] cafeClickables = Resources.LoadAll("Sprites/Environment/CafeInteriorObjects", typeof(Sprite));
        foreach (Object clickable in cafeClickables) {
            clickables.Add(clickable);
        }
    }

    // Get item by id
    public Item GetItem(int id) {
        return items.Find(item => item.id == id);
    }

    // Get item by name
    public Item GetItem(string itemName) {
        return items.Find(item => item.title == itemName);
    }

    public void AddItemToDatabase(Item item) {
        items.Add(item);
    }

    // Initialise items in database
    void BuildDatabase() {
        items = new List<Item>() {
            new Item(0, "Backpack", "Player's backpack.", "Sprites/Items/Backpack",
            new Dictionary<string, int> {
                {"Capacity", 15}
            }),
            new Item(1, "Brownbag", "Feeling hungry?", "Sprites/Items/Brownbag",
            new Dictionary<string, int> {
                {"Energy", 10}
            }),
            new Item(2, "Crescent", "Welcome to Moonwich Bay! This is your one-stop guide to all 3 attractions in our beautiful historic coastal town.", "Sprites/Environment/Crescent",
            new Dictionary<string, int> {
                {"Knowledge", 5}
            }),
        };
    }
}
