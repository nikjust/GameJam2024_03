using System;
using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeMenu : MonoBehaviour
{
#if UNITY_EDITOR
    [Scene]
#endif
    public string MenuScene;

    public GameObject canvas;

    public bool canvas_active = false;
    public FirstPersonController PlayerController;
    
    CursorLockMode curls;

    // Start is called before the first frame update

    public void Start()
    {
        PlayerController = FindFirstObjectByType<FirstPersonController>();
    }

    public void Toggle()
    {
        canvas_active = !canvas_active;
        canvas.SetActive(canvas_active);
        if (canvas_active)
        {
            PlayerController.enabled = !canvas_active;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            PlayerController.enabled = !canvas_active;
            Cursor.lockState = CursorLockMode.Locked;
        }

        
    }

    // Update is called once per frame
    public void LoadMenu()
    {
        SceneManager.LoadScene(MenuScene);
    }

    public void Restart()
    {
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Toggle();
        }
    }
}
