using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour
{
    public PlayerHealth PlayerHealth;

    public PlayerWin playerWin;
    public GameObject PoliceLeft;
    public GameObject PoliceRight;
    public GameObject Player;
    public Animator player;
    public GameObject lose;
    public GameObject win;
    public bool won;
    public GameObject textMeshPro;
    
    void Start()
    {
        textMeshPro.SetActive(true);
        won = false;
        player.SetBool("IsDead", false);
        lose.SetActive(false);
        win.SetActive(false);
        Invoke("deletemesh", 10f);
        Invoke("SpawnPolice", 40f);
    }
    void deletemesh()
    {
        textMeshPro.SetActive(false);
    }

    void Update()
    {
        if (PlayerHealth.isDead == true)
        {
            player.SetBool("IsDead", true);
            Player.GetComponent<PlayerController>().enabled = false;
            Player.GetComponent<PlayerCombat>().enabled = false;
            if (playerWin.gooddie == false)
            {
                lose.SetActive(true);
                Invoke("Restart", 5f);
            }
            else
            {
                win.SetActive(true);
                Invoke("NextScene", 5f);
            }
        }
    }
    public void SpawnPolice()
    {
        Instantiate(PoliceLeft, new Vector3(0f, -30f, 0f), Quaternion.identity);
        Instantiate(PoliceRight, new Vector3(-6f, -30f, 0f), Quaternion.identity);
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
