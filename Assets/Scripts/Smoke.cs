using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke : MonoBehaviour
{

    [SerializeField] GameObject plane;
    float alpha =1;

    void Start()
    {
        Reset();
    }

    
    void Update()
    {
        transform.Translate(new Vector3(-1f * Time.deltaTime, 0, 0));
        alpha -= 1f * Time.deltaTime;

        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alpha);

        if (alpha < 0)
        {
            Reset();
        }

    }

    private void Reset()
    {
        alpha = 1;
        GetComponent<SpriteRenderer>().color = Color.white;
        transform.position = plane.transform.position + new Vector3(-0.5f, 0, 0);
    }
        
}
