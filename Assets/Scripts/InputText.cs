using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Required when Using UI elements.

public class InputText : MonoBehaviour
{
    public InputField mainInputField;

    public void Start()
    {

        mainInputField.text = "Enter Text Here...";
    }

    public void Update()
    {

    }
}