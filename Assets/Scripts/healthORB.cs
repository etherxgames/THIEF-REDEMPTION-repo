using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthORB : MonoBehaviour
{
    public static bool healthOrbTaken = false;
    public GameObject HealthOrb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        healthOrbTaken = true;
        HealthOrb.SetActive(false);
    }
}
