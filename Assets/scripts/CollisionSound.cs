using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CollisionSound : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip[] sounds;
    public AudioSource audioSource;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        int randomNum = Random.Range(0, sounds.Length);
        audioSource.clip = sounds[randomNum];
        audioSource.loop = false;
        audioSource.Play();
    }
}
