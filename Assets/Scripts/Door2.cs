using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2 : MonoBehaviour
{

    public GameObject key2UI;
    public GameObject Door2UI;

    // Start is called before the first frame update
    void Start()
    {
        Door2UI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && Key2.hasKey2)
        {
            Door2UI.SetActive(false);
            key2UI.SetActive(false);
            Key2.hasKey2 = false;
        } 
    }
}
