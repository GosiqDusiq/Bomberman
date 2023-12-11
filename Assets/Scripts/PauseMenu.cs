using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool isPauseActive = false;

    void Start()
    {
        // Ensure the pause menu is initially inactive
        if (pauseMenu != null)
        {
            pauseMenu.SetActive(false);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPauseActive)
                Resume();
            else
                Pause();
        }
    }

    void Resume()
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

    void Pause()
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
}
