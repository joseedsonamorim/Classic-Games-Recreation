﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;

    void Start()
    {
        Launch();
    }

    public void Reset()
    {
 
        transform.position = startPosition;
        Launch();
    }
    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }
}
