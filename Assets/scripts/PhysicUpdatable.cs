using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicUpdatable : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody _rigidbody;
    void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _rigidbody.WakeUp();
    }
}
