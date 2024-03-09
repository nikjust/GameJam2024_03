using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
#if UNITY_EDITOR
    [Scene]
#endif
    public string NextScene;
    // Start is called before the first frame update
    public void Exit()
    {
        Application.Quit();
    }

    public void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    public void LoadGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene(NextScene);
    }
}
