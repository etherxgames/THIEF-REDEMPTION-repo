using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public static bool hasKey = false;

    public GameObject KeyUI;
    public GameObject Keyobject;

    // Start is called before the first frame update
    void Start()
    {
        KeyUI.SetActive(false);
        Keyobject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (hasKey)
        {
            KeyUI.SetActive(true);
            Keyobject.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            hasKey = true;
        }
    }
}
