using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;
    public float maxSpeed = 3f;
    public float minSpeed = -3f;
    public float acceleration;

    public float rotationPiece = 60f;
    public float rotationTimeMs = 750f;


    private Transform pTransform;
    private Rigidbody pRigidbody;
    public float angle = 0;
    public bool inverseRotation = false;


    // Start is called before the first frame update

    float InRange(float x, float minF, float maxF)
    {
        Debug.Log(x);
        if (x > maxF)
        {
            x = maxF;
        }
        else if (x < minF)
        {
            x = minF;
        }

        return x;
    }

    void Start()
    {
        pTransform = player.transform;
        pRigidbody = player.GetComponent<Rigidbody>();
    }

    private void Update()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float AdditionalMultiplier = 1f;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            AdditionalMultiplier = 1.5f;
        }
        
        
        if (Input.GetKey(KeyCode.W))
        {
            var velo = pRigidbody.velocity;
            pRigidbody.velocity = transform.rotation * Vector3.forward * (maxSpeed * AdditionalMultiplier);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            pRigidbody.velocity = transform.rotation * Vector3.back * (maxSpeed * AdditionalMultiplier);
        }

        if (Input.GetKey(KeyCode.D))
        {
            pTransform.RotateAround(pTransform.position, Vector3.up, 1);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            pTransform.RotateAround(pTransform.position, Vector3.up, -1);
        }

    }
}
