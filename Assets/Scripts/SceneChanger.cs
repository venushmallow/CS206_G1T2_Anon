using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    [SerializeField] private string sceneName;
    public void ChangeScene() {
        if (sceneName != "") {
            SceneManager.LoadScene(sceneName);
        }
        Debug.Log("Scene not defined!");
    }
}
