using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Fungus;

public class ExplorerManager : MonoBehaviour
{
    [SerializeField] private GameObject usbContent;
    [SerializeField] private GameObject video;
    [SerializeField] private Flowchart flowchart;
    [SerializeField] private GameObject searchBar;
    [SerializeField] private Text searchText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            processPassword();
        }
    }

    public void processPassword()
    {
        string search = searchText.text.ToLower();
        if (search.Contains("secret password"))
        {
            Debug.Log("passwordcorrect");
            Fungus.Flowchart.BroadcastFungusMessage("passcorrect");
        }   
        else
        {
            Debug.Log("passwordincorrect");
            Fungus.Flowchart.BroadcastFungusMessage("inputpassworddone");
        }
    }

    public void activateSearchBar()
    {
        searchBar.SetActive(!searchBar.activeSelf);
    }

    public void inputPassword()
    {
        Fungus.Flowchart.BroadcastFungusMessage("inputpassword");

    }

    public void showUSBContent()
    {
        usbContent.SetActive(!usbContent.activeSelf);
    }

    public void showFootage()
    {
        video.SetActive(!video.activeSelf);
        Fungus.Flowchart.BroadcastFungusMessage("openfootage");
    }

    public void ReturnToScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
