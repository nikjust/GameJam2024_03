using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyzFromMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public SaveManager saveManager;
    void Start()
    {
        gameObject.SetActive(saveManager.IsGameDone());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
