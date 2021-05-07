using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauseMenu : MonoBehaviour
{
    public Button pause;
    public Canvas theMenu;
    public static bool paused = false;

    public void Awake()
    {
        theMenu.enabled = false;
        Time.timeScale = 2f;
    }

    public void PauseGame()
    {
        paused = true;
        Time.timeScale = 0f;
        theMenu.enabled = true;
        //print("paused");
    }

    public void ResumeGame()
    {
        paused = false;
        Time.timeScale = 2f;
        theMenu.enabled = false;
        //print("resumed");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
