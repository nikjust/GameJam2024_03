using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class AngleRotator : MonoBehaviour
{
    // Start is called before the first frame update
    private float angle=0;
    public bool canRotate = false;
    public Behaviour fpsController;
    public float smoothRotationFactor = 50;

    void Start()
    {
    }

    // Update is called once per frame
    private float X;
    private float Y;
    private float Z;
    private float XCur;
    private float YCur;
    private float ZCur;


    void Update()
    {
       
        if (Input.GetKeyUp(KeyCode.H))
        {
            canRotate = !canRotate;
            fpsController.enabled = !canRotate;
            X = 0;
            Y = 0;
            Z = 0;
            XCur = 0;
            YCur = 0;
            ZCur = 0;
        } 
        if (!canRotate)
        {
            return;
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            Y += 90;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            Y -= 90;
        }
        
        if (Input.GetKeyUp(KeyCode.S))
        {
            X += 90;
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            X -= 90;
        }
        
        if (Input.GetKeyUp(KeyCode.Q))
        {
            Z += 90;
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            Z -= 90;
        }

        XCur += (X - XCur) / smoothRotationFactor;
        ZCur += (Z - ZCur) / smoothRotationFactor;
        YCur += (Y - YCur) / smoothRotationFactor;

        transform.rotation = Quaternion.Euler(XCur, YCur, ZCur);


        // lastX = transform.rotation.eulerAngles.x;
        // lastY = transform.rotation.eulerAngles.y;
    }
}