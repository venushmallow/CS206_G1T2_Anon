using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class WebBrowserImgScript : MonoBehaviour
{
    private Image image;
    public Fungus.Flowchart myFlowchart;

    private void Awake()
    {
        image = GetComponent<Image>();
        HideImage();
    }

    public void HideImage()
    {
        image.gameObject.SetActive(false);
    }

    public void Showimg()
    {
        image.gameObject.SetActive(true);
    }

    public void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            HideImage();
            myFlowchart.StopAllBlocks();
            myFlowchart.StopAllCoroutines();
            myFlowchart.ExecuteBlock("MainPageAfterCloseImg");
        }
    }
}
