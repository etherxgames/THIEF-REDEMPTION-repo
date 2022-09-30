using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public GameObject ending;

    void Start()
    {
        ending.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ending.SetActive(true);
            Invoke("Next", 4f);
        }
    }

    void Next()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
