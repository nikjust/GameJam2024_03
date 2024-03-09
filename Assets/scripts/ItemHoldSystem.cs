using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHoldSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject holded = null;
    public GameObject camera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (holded != null)
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                holded = null;
                return;
            }
            
            holded.GetComponent<Rigidbody>().velocity =
                (transform.position+(transform.rotation*Vector3.forward * 2)  - holded.transform.position)*5;
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 2, Color.green);
            Debug.DrawRay(holded.transform.position, transform.TransformDirection(Vector3.forward) * 2 - holded.transform.position, Color.blue);
            return;
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            int layerMask = 1 << 2;

            // This would cast rays only against colliders in layer 8.
            // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.
            layerMask = ~layerMask;

            RaycastHit hit;
            // Does the ray intersect any objects excluding the player layer
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2, layerMask))
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                if (!hit.rigidbody.isKinematic)
                {
                    holded = hit.transform.gameObject;
                }

                Debug.Log("Did Hit");
            }
            else
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
                Debug.Log("Did not Hit");
            }
        }
    }
}
