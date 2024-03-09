using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CodeLock : Activator
{
    // Start is called before the first frame update
    public string passPhrase;
    protected string passBuffer;
    public TMP_Text display;
    public Color goodColor = Color.green;
    public Color badColor = Color.red;
    private float _fixedTime;


    public void SetButtons(bool enabled)
    {
        var childs = gameObject.GetComponentsInChildren<UnityEngine.UI.Button>();
        foreach (var butt in childs)
        {
            butt.interactable = enabled;
        }
    }


    public void AddSymbol(string chr)
    {
       passBuffer += chr;
       display.text = passBuffer;
    }

    public void ClearBuffer()
    {
        passBuffer = "";
        display.text = passBuffer;
    }
    
    public void Check()
    {
        _activated = passBuffer == passPhrase;
        if (_activated)
        {
            SetButtons(false);
            display.color = goodColor;
        }
        else
        {
            _fixedTime = Time.time;
            display.color = badColor;
            SetButtons(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_fixedTime + 2 < Time.time && _fixedTime != 0)
        {
            ClearBuffer();
            display.color = Color.white;
            SetButtons(true);
            _fixedTime = 0;
        }
    }
}
