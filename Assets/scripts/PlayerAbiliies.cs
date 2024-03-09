using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbiliies : MonoBehaviour
{
    public bool alternativeMode = false;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.G))
        {
            alternativeMode = !alternativeMode;
            var changeArray = GameObject.FindObjectsOfType<AlternativeChangeable>();

            foreach (var go in changeArray)
            {
                go.setState(alternativeMode);
            }
        }


    }
}
