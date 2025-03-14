using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daBard : MonoBehaviour
{
    public GameManager gameManager; 
    public float velocity = 1;
    private Rigidbody2D rb;

    void Start() { rb = GetComponent<Rigidbody2D>(); }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
            rb.velocity = Vector2.up * velocity;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        gameManager.GameOver();
    }
}
