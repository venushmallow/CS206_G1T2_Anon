using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconScript : MonoBehaviour
{
    [SerializeField] public GameObject bg;
    [SerializeField] public GameObject phone;
    [SerializeField] public GameObject phones;
    [SerializeField] public GameObject location;
    [SerializeField] public GameObject email;
    [SerializeField] public GameObject urls;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showBg()
    {
        Debug.Log("showbg");
        bg.SetActive(!bg.activeSelf);
    }
    public void showPhone()
    {
        Debug.Log("showphone");
        phone.SetActive(!phone.activeSelf);
    }
    public void showPhones()
    {
        Debug.Log("showphones");
        phones.SetActive(!phones.activeSelf);
    }
    public void showLocation()
    {
        Debug.Log("showlocation");
        location.SetActive(!location.activeSelf);
    }
    public void showUrl()
    {
        Debug.Log("showwebsite");
        urls.SetActive(!urls.activeSelf);
    }
    public void showEmail()
    {
        Debug.Log("showemail");
        email.SetActive(!email.activeSelf);
    }


}
