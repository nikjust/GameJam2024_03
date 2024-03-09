using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlternativeChangeable : MonoBehaviour
{
    public bool alternativeEnabled = false;

    public Behaviour[] changeable = {};

    public Collider collider;
    public Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
                
    }

    public void setState(bool state)
    {
        
        foreach (Behaviour component in changeable)
        {
            component.enabled = (!state) ^ alternativeEnabled;
        }

        if (collider)
        {
            collider.enabled = (!state) ^ alternativeEnabled;
        }
        if (renderer)
        {
            renderer.enabled = (!state) ^ alternativeEnabled;
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
