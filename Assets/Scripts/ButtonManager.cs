﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    

    public void Menu()
    {
        SceneManager.LoadScene("Game");
    }
    public void ExitGame()

    {
        Application.Quit();
    }
}