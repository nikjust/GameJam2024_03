using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Button : Activable
{
    // Start is called before the first frame update
    [FormerlySerializedAs("Activator")] public string activator;
    public Material active;
    public Material unactive;
    private bool _activated = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override bool IsActive()
    {
        return _activated;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(activator))
        {
            gameObject.GetComponent<Renderer>().material = active;
            other.GetComponent<Activator>().Activate();
            _activated = true;
            
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(activator))
        {
            gameObject.GetComponent<Renderer>().material = unactive;
            other.GetComponent<Activator>().Deactivate();
            _activated = false;
        }
    }
}
