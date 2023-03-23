using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

public class Rocks : MonoBehaviour
{

    bool hasScored = false;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (transform.position.x < -6)
        {
            float height = Random.Range(-0.9f, 0.5f);
            transform.position = new Vector2(9, height);

            hasScored = false;
        }

        //Test de score
        float planeX = GameObject.Find("Plane").transform.position.x;
        if (transform.position.x <= planeX && !hasScored )
        {
            Debug.Log("SCORE!");
            hasScored = true;
            FindObjectOfType<GameManager>().AddScore();
        }
    }

    void OnStartGame()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-2, 0);
    }

    void OnGameOver()
    {
        enabled = false;
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }
}
