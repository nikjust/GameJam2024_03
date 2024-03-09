using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class DisapperingThing : MonoBehaviour
{
    // Start is called before the first frame update
    public Activable[] activators;
    public Collider collider;
    public Renderer renderer;
    public bool Enabled;
    public bool Inverse;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        foreach (var activator in activators)
        {
            if (!activator.IsActive())
            {
                Enabled = false;
                if (Inverse)
                    Enabled = !Enabled;
                collider.enabled = Enabled;
                renderer.enabled = Enabled;
                return;
            }
        }

        Enabled = true;
        if (Inverse)
            Enabled = !Enabled;
        collider.enabled = Enabled;
        renderer.enabled = Enabled;
    }
}
