using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
{

    public float vibrationRange = 0.5f;
    float alpha = 1;
    Vector3 cameraPos;

    void Start()
    {
        cameraPos = Camera.main.transform.position;
    }

    
    void Update()
    {
        alpha -= 3f * Time.deltaTime;
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alpha);

        Camera.main.transform.position = new Vector3(Random.Range(-vibrationRange, vibrationRange), Random.Range(-vibrationRange, vibrationRange), Camera.main.transform.position.z);


        if (alpha < 0)
        {
            Camera.main.transform.position = cameraPos;
            enabled = false;
        }
    }
}
