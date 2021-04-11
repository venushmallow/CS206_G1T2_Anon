using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class SecInfoManager : MonoBehaviour
{

    public List<SecInfo> secInfos = new List<SecInfo>();
    [SerializeField] private GameObject secInfoOverlay;
    [SerializeField] private Text title;
    [SerializeField] private Text description;
    [SerializeField] private GameObject terms;

    void Awake() {
        BuildSecInfoDatabase();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void processClick() {
        int id = Int32.Parse((string)EventSystem.current.currentSelectedGameObject.name);

        SecInfo info = GetInfo(id);

        title.text = info.getTitle();
        description.text = info.getDesc();
        secInfoOverlay.SetActive(true);
    }

    // Get info by id
    public SecInfo GetInfo(int id) {
        return secInfos.Find(info => info.id == id);
    }

    // Get info by name
    public SecInfo GetInfo(string infoTitle) {
        return secInfos.Find(info => info.title == infoTitle);
    }

    public void AddInfoToDatabase(SecInfo secInfo) {
        secInfos.Add(secInfo);
    }

    public void Activate_Terms_Scene1() {
        for (int i = 0; i < 6; i++) {
            Transform childObj = terms.transform.Find(i.ToString());
            childObj.gameObject.SetActive(true);
        }
    }

    public void Activate_Terms_Scene2() {
        Transform childObj = terms.transform.Find(6.ToString());
        childObj.gameObject.SetActive(true);
    }

    public void Activate_Terms_Scene3() {
        for (int i = 7; i < 10; i++) {
            Transform childObj = terms.transform.Find(i.ToString());
            childObj.gameObject.SetActive(true);
        }
    }

    void BuildSecInfoDatabase() {
        secInfos = new List<SecInfo>() {
            new SecInfo(0, "Cyber Kill Chain", "Category: General\n- Defined by Lockheed Martin\n\n- Consists of 7 phases\n1) Reconnaissance (Gathering information)\n2) Weaponization (Creating a payload to infiltrate)\n3) Delivery (Delivering payload to victim)\n4) Exploitation\n5) Installation (eg. malware)\n6) Command & Control (Taking control of victim's system)\n7) Actions on Objectives (Intruders accomplish original goals)\n"),
            new SecInfo(1, "VPN", "Category: General\nVirtual private networks\n\nVPNs allow you to:\n1) Spoof your location, making it look like you're browsing from a different physical location\n2) Access content available in other regions but not your physical region\n3) Encrypt and transfer data securely, your online activities will be hidden from public networks.\n"),
            new SecInfo(2, "OSINT", "Category: General\nOpen source intelligence\n- Performed during the reconnaissance stage of the cyber kill chain.\n\nAll publicly-available material is game for OSINT practitioners. That ranges from what you list publicly on social media accounts, to information on websites that are no longer available (thanks to the Wayback Machine, which keeps an archive of websites), from news articles to government sites."),
            new SecInfo(3, "Dorking", "Category: OSINT\nGoogle Dorking (but not just Google is capable of this)\nA user can combine operators to make their search more specific.\nOperators include, but are not limited to:\n1) site: (to specify a search within a single site)\n2) Operators like +, -, OR (to combine multiple terms)\nAnd etc. For a more comprehensive list, check out the Google Search Help page.\n"),
            new SecInfo(4, "Sock puppets", "Category: OSINT\nIf you have a social media account, you'd probably know how the platform sometimes makes new friend suggestions based on your existing pool of friends / followers / etc. Well, sock puppets aim to prevent this when you're conducting OSINT on social media, especially if you're gathering information on a stranger.\nSometimes, OSINT practitioners would also engage with their target directly (eg. exchanging messages) using their fake account."),
            new SecInfo(5, "Username Correlation", "Category: OSINT\nA number of people reuse their usernames across different platforms. Username correlation involves looking for the various accounts where a particular username is used, in the search for more information on a person or entity.\n\nSome profile landmarks you could look out for to ensure you have the right person, are birth dates, friends, location, etc. (consistent information)."),
            new SecInfo(6, "Shodan", "Category: OSINT\nWebsite: shodan.io\n\nShodan is a search engine for internet-connected devices. Imagine a Yellow Pages, but with the IP addresses of various machines around the world which are connected to the Internet.\n\nYou can search by state, country, etc. There's a lot to unpack regarding Shodan, so the only way to learn is to visit the website and explore."),
            new SecInfo(7, "Maltego", "Category: OSINT\nMaltego is an open source intelligence (OSINT) and graphical link analysis tool for gathering and connecting information for investigative tasks.\n\nMaltego uses transforms, which are small pieces of code which automatically fetch data from different resources (eg. websites, social media accounts), and create a visual representation of the data."),
            new SecInfo(8, "USB Sniffer", "Category: Network\n, USB Sniffer is a software tool that enables monitoring USB ports activity on a Windows machine."),
            new SecInfo(9, "Master Password", "Category: General\nA master password may refer to the password used by an admin, or an algorithm designed to create unique passwords in a reproducible manner.")
        };
    }
}
