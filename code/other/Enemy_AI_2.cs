using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI_2 : MonoBehaviour
{
    private Rigidbody2D rb;
    public Transform WallDetect;
    public bool WallDetected;
    public int Direction;
    public float CheckRadius;
    public LayerMask WhatIsGround;
    public bool right;
    public bool down;
    public bool left;
    public bool up;
    float Countdown;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Direction = 1;
       
    }

    // Update is called once per frame
    void Update()
    {
        WallDetected = Physics2D.OverlapCircle(WallDetect.position, CheckRadius, WhatIsGround);

        if (WallDetected)
        {
            if (right && Countdown < 0)
            {
                transform.rotation = Quaternion.Euler(-180, 0, 0);
                down = true;
                right = false;
                Countdown = 1;
            }
            else if (down && Countdown < 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, 90);
                left = true;
                down = false;
                Countdown = 1;
            }
            else if (left && Countdown < 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
               left = false;
               up = true;
                Countdown = 1;
            }
            else if (up && Countdown < 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, -90);
               
               up = false;
              right = true;
                Countdown = 1;
            }


        }
        Countdown -= Time.deltaTime;
        if (right)
        {
            rb.velocity = Vector2.right * 7;
        }
        if (down)
        {
            rb.velocity = Vector2.down * 7;
        }
        if (left)
        {
            rb.velocity = Vector2.left * 7;
        }
        if (up)
        {
            rb.velocity = Vector2.up * 7;
        }
    }
}

