using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecInfo
{
    public int id;
    public string title;
    public string description;
    public bool learned = false;

    // create new info
    public SecInfo(int id, string title, string description) {
        this.id = id;
        this.title = title;
        this.description = description;
    }
    
    // copy over info
    public SecInfo(SecInfo secInfo) {
        this.id = secInfo.id;
        this.title = secInfo.title;
        this.description = secInfo.description; 
    }

    public void setLearned() {
        this.learned = true;
    }

    public string getTitle() {
        return this.title;
    }

    public string getDesc() {
        return this.description;
    }
}
