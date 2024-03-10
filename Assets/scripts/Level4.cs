using System;
using System.Collections;
using System.Collections.Generic;
using MyBox;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level4 : MonoBehaviour
{
//TODO:сделой
    public bool Flower = false;
    public bool Player = false;
    public bool Box = false;

    [ConditionalField("Player")] public bool gotFertilizer = false;

    [ConditionalField("Flower")] public bool grow = false;
    [ConditionalField("Flower")] public Vector3 targetSize;
    [ConditionalField("Flower")] public float smoothFactor;
    [ConditionalField("Flower")] public float tolerance = 1;

    private bool f = false;

    private void Update()
    {
        if (!Flower)
            return;
        gameObject.GetComponent<Rigidbody>().WakeUp();
    }

#if UNITY_EDITOR
    [Scene]
#endif
    [ConditionalField("Flower")]
    public string NextScene;

    public void FixedUpdate()
    {
        if (!grow || !Flower)
            return;


        transform.localScale += (targetSize - transform.localScale) / smoothFactor;

        if ((targetSize - transform.localScale).magnitude < tolerance)
        {
            SceneManager.LoadScene(NextScene);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && Flower && other.GetComponent<Level4>().gotFertilizer)
        {
            grow = true;
        }
        else if (other.CompareTag("Player") && Box)
        {
            other.GetComponent<Level4>().gotFertilizer = true;
            Destroy(gameObject);
        }
    }
}