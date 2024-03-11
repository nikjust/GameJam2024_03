using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void GameDone()
    {
        PlayerPrefs.SetInt("Done", 1);
        PlayerPrefs.Save();
    }
     
    public bool IsGameDone()
    {
        int done = PlayerPrefs.GetInt("Done", 0);
        return done == 1;
    }
}
