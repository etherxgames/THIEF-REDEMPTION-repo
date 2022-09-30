using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1 : MonoBehaviour
{

    public GameObject key1UI;
    public GameObject Door1UI;
    public bool door1Active;
    // Start is called before the first frame update
    void Start()
    {
        Door1UI.SetActive(true);
        door1Active = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && Key1.hasKey1)
        {
            Door1UI.SetActive(false);
            door1Active = false;
            key1UI.SetActive(false);
            Key1.hasKey1 = false;
        }
    }
}