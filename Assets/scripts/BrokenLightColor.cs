using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenLightColor : MonoBehaviour
{
    public Light light;
    
    // Start is called before the first frame update
    void Start()
    {
        light = gameObject.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        light.color = new Color(-1f, -1f, -1f, 1);
    }
}
