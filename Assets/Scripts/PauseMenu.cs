using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool isPauseActive = false;

    public void Start()
    {
        // Ensure the pause menu is initially inactive
        if (pauseMenu != null)
        {
            pauseMenu.SetActive(false);
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPauseActive)
                Resume();
            else
                Pause();
        }
    }

    public void Resume()
    {
        // Unpause the game
        Time.timeScale = 1f;

        // Deactivate the pause menu
        if (pauseMenu != null)
        {
            pauseMenu.SetActive(false);
        }

        isPauseActive = false;
    }

    public void Pause()
    {
        // Pause the game
        Time.timeScale = 0f;

        // Activate the pause menu
        if (pauseMenu != null)
        {
            pauseMenu.SetActive(true);
        }

        isPauseActive = true;
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player Has Quit The Game");
    }
}
