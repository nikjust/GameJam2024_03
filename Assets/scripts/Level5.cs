using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level5 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] toEnable;
    public GameObject[] toDisable;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Trigger Entered");
            foreach (var go in toEnable)
            {
                go.SetActive(true);
            }
            foreach (var go in toDisable)
            {
                go.SetActive(false);
            }
        }
    }
}
