﻿using UnityEngine;
using System.Collections;

public class Fading : MonoBehaviour
{

    public Texture2D fadeOutTexture;//the texture that will overlay the screen
    public float fadeSpeed = 0.8f; // the fading speed

    private int drawDepth = -1000;//the texture's order in the draw hierarchy: a low number means it renders on top
    private float alpha = 1.0f; // texture's alpha value between 0-1;
    private int fadeDir = -1; //the direction to fade in=-1 or out=1;
                              // Use this for initialization
    void OnGUI()
    {
        //fade out/in the alpha value using a direction, a speed and Time.deltatime to convert operation to seconds
        alpha += fadeDir * fadeSpeed * Time.deltaTime;
        //force (clamp) the number between 0-1 because GUI.color uses alpha values between 0-1
        alpha = Mathf.Clamp01(alpha);
        //set color of our GUI (in this case our texture). All color values remain the same & the Alpha is set to the alpha variable
        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);//set alpha value
        GUI.depth = drawDepth;//make the black texture render on top
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeOutTexture);//draw the texture to fit entire screen


    }
    //sets fadeDir to the direction parameter makling the sceene fade in if -1 and out if 1
    public float BeginFade(int direction)
    {
        fadeDir = direction;
        return (fadeSpeed);//reture fade speed variable so its easy to time application.loadLevel();
    }
    //OnLevelWasLoaded is called when a level is loaded. It takes loaded level index(int) as a parameter so you can limit the fade in to certain scenes
    void OnLevelWasLoaded() {
        //alpha=1;//use this if the alpha is not set to 1 by default
        BeginFade(-1);//call fade in function
    }



}