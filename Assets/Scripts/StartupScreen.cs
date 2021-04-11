using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class StartupScreen : MonoBehaviour
{
    private Animator buttonAnim;
    void Start() { 
        buttonAnim = GetComponent<Animator>();
    }

    public void StartGame() {
        buttonAnim.SetTrigger("Pressed");
        SceneManager.LoadScene("Tutorial");
    }
}
