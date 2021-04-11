using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public int id;
    public string title;
    public string description;
    public Sprite icon;
    public string iconFilepath;
    public Dictionary<string, int> stats = new Dictionary<string, int>();

    // for item creation
    public Item(int id, string title, string description, string iconFilepath, Dictionary<string, int> stats) {
        this.id = id;
        this.title = title;
        this.description = description;
        this.icon = Resources.Load<Sprite>(iconFilepath);
        this.iconFilepath = iconFilepath;
        this.stats = stats;
    }

    // copy over item and its values
    public Item(Item item) {
        this.id = item.id;
        this.title = item.title;
        this.description = item.description;
        this.icon = Resources.Load<Sprite>(item.iconFilepath);
        this.iconFilepath = item.iconFilepath;
        this.stats = item.stats;
    }
}
