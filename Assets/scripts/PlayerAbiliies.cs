using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbiliies : MonoBehaviour
{
    public bool alternativeMode = false;
    public AudioClip music;
    public AudioClip altMusic;
    public AudioSource audioSource;
    
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

            var moment = audioSource.time;
            audioSource.clip = alternativeMode ? altMusic : music;
            audioSource.Play();
            audioSource.time = moment;
            

            foreach (var go in changeArray)
            {
                go.setState(alternativeMode);
            }
        }


    }
}
