using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    private float angle;

    void Start()
    {
        angle = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.H))
            angle += 90;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}
