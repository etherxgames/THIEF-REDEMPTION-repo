using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerWin : MonoBehaviour
{
    public GameManager2 GameManager;
    public PlayerHealth PlayerHealth;
    public GameObject win;
    public Door1 door1;
    public Door2 door2;
    public TMPro.TextMeshProUGUI endText;
    public bool gooddie;
    void Start()
    {
        gooddie = false;
        endText.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if(door1.door1Active == false && door2.door2Active == false)
        {
            endText.color = Color.green;
            GameManager.won = true;

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(GameManager.won == true)
            {
                gooddie = true;
                GameManager.SpawnPolice();
            }
        }
    }

    
}
