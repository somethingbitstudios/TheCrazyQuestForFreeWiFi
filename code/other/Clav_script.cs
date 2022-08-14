using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clav_script : MonoBehaviour
{
    GameObject player;
    public Animator animator;
    Rigidbody2D rb;
    Transform playerTransform; 
    // get player position
    Vector3 PLRposition;
    Vector3 position;
    public float Speed;
    public float MaxSpeed;
    public float CalmTime;
    public float ClawTime;
    public float time;
    public bool Claw;
    // Start is called before the first frame update
    void Start()
    {
        time = CalmTime;
        Claw = true;
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player");
        playerTransform = player.transform;
        // get player position
        PLRposition = playerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        PLRposition = playerTransform.position;
        position = rb.position;


        //porovnej a hybej
        if (PLRposition.x > position.x && rb.velocity.x < MaxSpeed)
        {
            rb.velocity = new Vector2(rb.velocity.x + Speed, rb.velocity.y);
        }
        else if (PLRposition.x < position.x && rb.velocity.x > -MaxSpeed)
        {
            rb.velocity = new Vector2(rb.velocity.x - Speed, rb.velocity.y);
        }
       
        if (PLRposition.y > position.y && rb.velocity.y < MaxSpeed)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y + Speed);
        }
        else if (PLRposition.y < position.y && rb.velocity.y > -MaxSpeed)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y - Speed);
        }


        //clawing
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else
        {
            if (Claw == true)
            {
                animator.SetBool("Claw", true);
                gameObject.layer = 9;
                time = ClawTime;
                Claw = false;
            }
            else
            {
                animator.SetBool("Claw", false);
                gameObject.layer = 8;
                time = CalmTime;
                Claw = true;
            }
        }





    }

    }
