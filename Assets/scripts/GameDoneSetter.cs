using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDoneSetter : MonoBehaviour
{
    // Start is called before the first frame update
    public SaveManager saveManager;
    void Start()
    {
        saveManager.GameDone();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
