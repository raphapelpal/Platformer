﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void GetBackRunning()
    {
        Time.timeScale = 1f;
    }

    
}
