using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheEndTitles : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 startPosition;
    public Vector3 endPosition;
    public float duration;
    public float pauseTime;
    public Door exitDoor;
    public RectTransform rt;
    
    private float _startTime;
    void Start()
    {
        _startTime = Time.time;
    }
    
    // Update is called once per frame
    void Update()
    {
        rt.localPosition = Vector3.Lerp(startPosition, endPosition, Math.Min((Time.time-_startTime)/duration, 1));

        if (_startTime + duration + pauseTime < Time.time)
        {
            SceneManager.LoadScene(exitDoor.NextScene);
        }
    }
}
