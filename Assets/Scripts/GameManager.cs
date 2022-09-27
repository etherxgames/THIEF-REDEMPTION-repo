using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject PoliceLeft;
    public GameObject PoliceRight;
    void Start()
    {
        Invoke("SpawnPolice", 10f);
        
    }

    void Update()
    {
        
    }

    void SpawnPolice()
    {
        Instantiate(PoliceLeft, new Vector3(60f, -2f, 0f), Quaternion.identity);
        Instantiate(PoliceLeft, new Vector3(50f, -2f, 0f), Quaternion.identity);
        Instantiate(PoliceRight, new Vector3(40f, -2f, 0f), Quaternion.identity);
        Instantiate(PoliceRight, new Vector3(30f, -2f, 0f), Quaternion.identity);
        Instantiate(PoliceRight, new Vector3(20f, -2f, 0f), Quaternion.identity);
        Instantiate(PoliceRight, new Vector3(10f, -2f, 0f), Quaternion.identity);
        Instantiate(PoliceLeft, new Vector3(0f, -2f, 0f), Quaternion.identity);
    }
}
