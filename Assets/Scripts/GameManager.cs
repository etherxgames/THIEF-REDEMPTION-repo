using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public PlayerHealth PlayerHealth;
    public GameObject PoliceLeft;
    public GameObject PoliceRight;
    public GameObject Player;
    public GameObject Angel;
    public GameObject txt1;
    public GameObject txt2;
    public Animator player;
    void Start()
    {
        player.SetBool("IsDead", false);
        Invoke("SpawnPolice", 10f);
        Angel.SetActive(false);
        txt1.SetActive(false);
        txt2.SetActive(false);
    }

    void Update()
    {
        if(PlayerHealth.isDead == true)
        {
            player.SetBool("IsDead", true);
            Player.GetComponent<PlayerController>().enabled = false;
            Player.GetComponent<PlayerCombat>().enabled = false;
            Angel.SetActive(true);
            txt1.SetActive(true);
            txt2.SetActive(true);
            if(Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }

        }
    }
    void SpawnPolice()
    {
        Instantiate(PoliceLeft, new Vector3(60f, -2f, 0f), Quaternion.identity);
        Instantiate(PoliceRight, new Vector3(50f, -2f, 0f), Quaternion.identity);
        Instantiate(PoliceRight, new Vector3(40f, -2f, 0f), Quaternion.identity);
        Instantiate(PoliceRight, new Vector3(30f, -2f, 0f), Quaternion.identity);
        Instantiate(PoliceRight, new Vector3(20f, -2f, 0f), Quaternion.identity);
        Instantiate(PoliceRight, new Vector3(10f, -2f, 0f), Quaternion.identity);
        Instantiate(PoliceLeft, new Vector3(0f, -2f, 0f), Quaternion.identity);
    }
}
