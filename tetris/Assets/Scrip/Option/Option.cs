﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour
{
    [SerializeField]
    private GameObject PausePanel;

    void Awake()
    {
        PausePanel.SetActive(false);
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        PausePanel.SetActive(true);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
        PausePanel.SetActive(false);
    }
    public void ExitGame()
    {
        Time.timeScale = 1f;
        Application.LoadLevel("Menu");
    }
}
