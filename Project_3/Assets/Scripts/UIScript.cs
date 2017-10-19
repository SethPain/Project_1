using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour {
    public void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void QuitGameButton()
    {
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #else
        Application.Quit();
    #endif
    }

    public void StartFirstScene()
    {
        SceneManager.LoadScene("Scene_1");
    }

    public void StartSecondScene()
    {
        SceneManager.LoadScene("Scene_2");
    }

    public void StartMenu()
    {
        SceneManager.LoadScene("Scene_0");
    }
}
