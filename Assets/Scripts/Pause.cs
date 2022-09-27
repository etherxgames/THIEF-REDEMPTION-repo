using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject PauseMenuUI;
    public GameObject ReturnToMenuUI;


    // Update is called once per frame
    void Update()
    {
        if (PauseMenu.GameIsPaused && PauseMenu.ReturnTOMenu)
        {
            ReturnToMenuUI.SetActive(false);
            PauseMenuUI.SetActive(true);
            PauseMenu.ReturnTOMenu = false;
        }
    }

    public void ReturnToPause()
    {
        ReturnToMenuUI.SetActive(false);
        PauseMenuUI.SetActive(true);
        PauseMenu.ReturnTOMenu = false;
    }
}
