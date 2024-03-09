using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    // Start is called before the first frame update
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

    public bool IsActive()
    {
        return _activated;
    }

    public void Activate()
    {

            gameObject.GetComponent<Renderer>().material = active;
            _activated = true;

    }
    
    public void Deactivate()
    {

            gameObject.GetComponent<Renderer>().material = unactive;
            _activated = false;
    }
}
