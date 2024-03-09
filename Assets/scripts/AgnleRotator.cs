using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleRotator : MonoBehaviour
{
    // Start is called before the first frame update
    private float angle;
    public bool canRotate = false;
    

    void Start()
    {
        angle = 0;
    }

    // Update is called once per frame
    private float lastX;
    private float lastY;

    void Update()
    {
        if (!canRotate)
        {
            return;
        }

        if (angle != 0 && (lastX != transform.rotation.eulerAngles.x || lastY != transform.rotation.eulerAngles.y))
        {
            angle = 0;
        }

        if (Input.GetKeyUp(KeyCode.H))
        {
            angle += 90;
            var x = transform.rotation.eulerAngles.x;
            var y = transform.rotation.eulerAngles.y;
            var z = transform.rotation.eulerAngles.z;
            transform.rotation = Quaternion.Euler(new Vector3(x, y, z + angle));
        }

        lastX = transform.rotation.eulerAngles.x;
        lastY = transform.rotation.eulerAngles.y;
    }
}