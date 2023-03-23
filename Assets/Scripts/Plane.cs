using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    [SerializeField]
    public int JumpHeight;

    [SerializeField] AudioClip soundJump;
    [SerializeField] AudioClip soundCrash;
    [SerializeField] AudioClip soundCoin;

    void Start()
    {
        Debug.Log("I am the Plane, Hello World!");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Jump();
        }

        // Nose Orientation
        float rotAngle = GetComponent<Rigidbody2D>().velocity.y * 3f;
        transform.eulerAngles = new Vector3(0, 0, rotAngle);

    }

    void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3(0, JumpHeight, 0);

        GetComponent<AudioSource>().PlayOneShot(soundJump);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("On Collision with : " + collision.gameObject.name);
        FindObjectOfType<GameManager>().GameOver();

        GetComponent<AudioSource>().PlayOneShot(soundCrash);
        GetComponent<CircleCollider2D>().enabled = false;
    }

    void OnStartGame()
    {
        enabled = true;
        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        Jump();
    }

    void OnGameOver()
    {
        enabled = false;
        //GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX;
        //GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
    }
}
