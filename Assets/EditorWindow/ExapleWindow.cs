﻿using UnityEngine;
using UnityEditor;

public class ExapleWindow : EditorWindow
{
    Color color;

    [MenuItem("Window/Colorizer")]
    public static void ShowWindow()
    {
        GetWindow<ExapleWindow>("Colorizer");
    }

    void OnGUI ()
    {
        GUILayout.Label("Color the selected objects", EditorStyles.boldLabel);

        color = EditorGUILayout.ColorField("Color", color);

        if (GUILayout.Button("COLORIZE"))
        {
            Colorize();
        }
    }

    void Colorize ()
    {
        foreach (GameObject obj in Selection.gameObjects)
        {
            Renderer renderer = obj.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.sharedMaterial.color = color;
            }
        }
    }

}
