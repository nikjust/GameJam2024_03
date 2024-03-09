using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    public Activable[] activators;
    public Material inactiveMaterial;
    public Material activeMaterial;
    private Renderer _renderer;
#if UNITY_EDITOR
    [Scene]
    #endif
    public string NextScene;
    public bool active = false;
    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        foreach (var activator in activators)
        {
            if (!activator.IsActive())
            {
                _renderer.material = inactiveMaterial;
                active = false;
                return;
            }
        }
        _renderer.material = activeMaterial;
        active = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && active)
        {
            SceneManager.LoadScene(NextScene);
        }
    }
}
