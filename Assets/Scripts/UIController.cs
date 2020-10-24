﻿using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Image blackOverlay;
    public Image backButton;
    public Image resumeButton;
    public Image restartButton;
    public Image helpButton;
    public Image quitButton;
    //public Image helpScreen;

    void Start()
    {
        blackOverlay.enabled = false;
        backButton.enabled = false;
        resumeButton.enabled = false;
        restartButton.enabled = false;
        helpButton.enabled = false;
        quitButton.enabled = false;
        //helpScreen.enabled = false;
    }

    void Update()
    {
        //ESCAPE KEY
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }  
    }

    //PAUSE & RESUME
    public void Pause()
    {
        if(Time.timeScale == 1)
        {
            Time.timeScale = 0;
            blackOverlay.enabled = true;
            resumeButton.enabled = true;
            helpButton.enabled = true;
            quitButton.enabled = true;
        }
        else
        {
            Time.timeScale = 1;
            blackOverlay.enabled = false;
            resumeButton.enabled = false;
            helpButton.enabled = false;
            quitButton.enabled = false;
        }
    }

    //HELP
    public void Help()
    {
        //bring up Help Screen
    }

    //QUIT
    public void Quit()
    {
        Application.Quit();
    }

    //BACK
    public void Back()
    {
        //hide whatever menu and buttons are showing
    }

}
