using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(SaveManager))]
public class SaveResetter : Editor
{
    public override void OnInspectorGUI() {
        if (GUILayout.Button("Reset save"))
        {
            PlayerPrefs.SetInt("Done", 0);
            PlayerPrefs.Save();
        }
    }
}
