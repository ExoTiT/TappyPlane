using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnRetry : MonoBehaviour
{
 
    void Start()
    {
        
    }

  
    void Update()
    {
        
    }


    private void OnMouseUpAsButton()
    {
        Debug.Log("RETRY");
        SceneManager.LoadScene("SampleScene");
    }
}
