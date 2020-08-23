using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool player1;
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;

    private float movement;

    private void Start()
    {
        startPosition = transform.position;
    }
    
    void Update()
    {
        if (player1)
        {
            movement = Input.GetAxis("Vertical");
        }
        else
        {
            movement = Input.GetAxis("Vertical2");
        }

        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
