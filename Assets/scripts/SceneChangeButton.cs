using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeButton : MonoBehaviour
{
    public int sceneNum;
    public void Change()
    {
        SceneManager.LoadScene(sceneNum);
    }
}

