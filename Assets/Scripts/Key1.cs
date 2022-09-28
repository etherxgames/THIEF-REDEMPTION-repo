using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key1 : MonoBehaviour
{
    public static bool hasKey1 = false;

    public GameObject KeyUI;
    public GameObject Key_1;

    // Start is called before the first frame update
    void Start()
    {
        KeyUI.SetActive(false);
        Key_1.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (hasKey1 && !Key2.hasKey2)
        {
            KeyUI.SetActive(true);
            Key_1.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player" && !hasKey1 && !Key2.hasKey2)
        {
            hasKey1 = true;
        }
    }
}
