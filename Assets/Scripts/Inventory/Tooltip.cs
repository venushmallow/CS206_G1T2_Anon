﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour
{
    private Text tooltipText;
    
    void Start() {
        tooltipText = GetComponentInChildren<Text>();
        tooltipText.gameObject.SetActive(false);
        gameObject.SetActive(false);
    }

    public void GenerateTooltip(Item item) {
        string statText = "";
        if (item.stats.Count > 0) {
            
            foreach(var stat in item.stats) {
                statText += stat.Key.ToString() + ": " + stat.Value.ToString() + "\n";
            }

        }

        string tooltip = string.Format("<b>{0}</b>\n{1}\n\n<b>{2}</b>", item.title, item.description, statText);
        tooltipText.text = tooltip;
        tooltipText.gameObject.SetActive(true);
        gameObject.SetActive(true);
    }
}
