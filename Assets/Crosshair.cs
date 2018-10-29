using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    public Texture2D crosshair;
    private Rect position;

    private void Start()
    {
        crosshair = Texture2D.whiteTexture;
    }

    // Update is called once per frame
    void Update()
    {
        position = new Rect((Screen.width - crosshair.width) / 2, (Screen.height - crosshair.height) / 2, crosshair.width, crosshair.height);
    }

    void OnGUI()
    {
        GUI.DrawTexture(position, crosshair);
    }
}
