using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Put4 : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }   
}
