using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Police;
    void Start()
    {
        Invoke("SpawnPolice", 10f);
        
    }

    void Update()
    {
        
    }

    void SpawnPolice()
    {
        Instantiate(Police, new Vector3(60f, -2f, 0f), Quaternion.identity);
        this.Flip();
        Instantiate(Police, new Vector3(50f, -2f, 0f), Quaternion.identity);
        
        Instantiate(Police, new Vector3(40f, -2f, 0f), Quaternion.identity);
    }

    void Flip()
    {
        Vector2 currentScale = transform.localScale;
        currentScale.x *= -1;
        transform.localScale = currentScale;
    }

}
