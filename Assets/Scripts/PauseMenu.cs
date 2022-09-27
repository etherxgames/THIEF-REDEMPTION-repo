using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public static bool ReturnTOMenu = false;
    public GameObject PauseMenuUI;
    public GameObject ReturnTOMenuUI;


    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused && !ReturnTOMenu)
            {
                Resume();
            }
            else if (!GameIsPaused && !ReturnTOMenu)
            {
                Pause();
            }
            else if (GameIsPaused && ReturnTOMenu)
            {
                ReturnTOMenuUI.SetActive(false);
                PauseMenuUI.SetActive(true);
                ReturnTOMenu = false;
            }
        }
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1.0f;
        GameIsPaused = false;
    }
    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void setReturnToMenu()
    {
        ReturnTOMenu = true;
    }
    public void ReturnToMainMenu()
    {
        GameIsPaused = false;
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("MainMenu");
    }
}

