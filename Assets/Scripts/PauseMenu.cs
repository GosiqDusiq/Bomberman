using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool isPauseActive = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
        pauseMenu.SetActive(false);
        isPauseActive = false;
    }
    void Pause()
    {
        pauseMenu.SetActive(true);
        isPauseActive = true;
    }
}
