using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key2 : MonoBehaviour
{
    public static bool hasKey2 = false;

    public GameObject KeyUI;
    public GameObject Key_2;

    // Start is called before the first frame update
    void Start()
    {
        KeyUI.SetActive(false);
        Key_2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (hasKey2 && !Key1.hasKey1)
        {
            KeyUI.SetActive(true);
            Key_2.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && !hasKey2 && !Key1.hasKey1)
        {
            hasKey2 = true;
        }
    }
}