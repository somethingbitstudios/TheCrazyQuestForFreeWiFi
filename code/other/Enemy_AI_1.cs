using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI_1 : MonoBehaviour
{
    private Rigidbody2D rb; 
    public Transform WallDetect;
    public bool WallDetected;
    public int Direction;
    public float CheckRadius;
    public LayerMask WhatIsGround;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Direction = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        WallDetected = Physics2D.OverlapCircle(WallDetect.position, CheckRadius, WhatIsGround);
       
        if (WallDetected)
        {
            Direction = Direction * -1;
        }
        rb.velocity = Vector2.left * 10 * Direction;
        if (rb.velocity.x > 0)
        {
            transform.localScale = new Vector3(-1, 1, 0);
        }
        else
        {
            transform.localScale = new Vector3(1, 1, 0);
        }
    }
}
