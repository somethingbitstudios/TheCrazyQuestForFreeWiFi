using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_v2 : MonoBehaviour
{
    private Rigidbody2D rb;

    public Animator animator;
    float Speed;
    public float MaxSpeed;
    public float Acceleration;
    public float GRNDAcceleration;
    public float AIRAcceleration;

    public float Decceleration;
    public float GRNDecceleration;
    public float AIRDecceleration;

    public float WAcceleration;
    public float WDecceleration;

    public bool IsGrounded;
    public bool LeftWall;
    public bool RightWall;
    public Transform FeetPos;
    public Transform LeftPos;

    public float CheckRadius;
    public LayerMask WhatIsGround;
    public float DefaultJumpForce;
    public float JumpForce;
    float JumpTime;
    public float DefaultJumpTime;

    public float WallJump;

    public bool IsJumping;

    //Drone
    public bool CanDrone;
    public float DefaultDroneTime;
    public float MaxForce;
    public bool IsDroning;
    public bool HasDrone;
    float DroneTime;

    //Quantum Booster
    float QBoost;
    float ActualBoost;
    public bool CanBoost;
    float NoBoostTime;
    public bool HasBooster;


    //Collision Distorter
    public bool CanDist;
    public float DefDistTime;
    float DistTime;
    public bool HasDist;
    public bool IsDisting;
    public float DefNoDistTime;
    float NoDistTime;


    public bool IsWallJumping;
    public float WallJumpTime;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ActualBoost = 1;
        QBoost = 0;
        CanBoost = true;
        CanDist = true;

    }
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && CanBoost == true && HasBooster == true)
        {
            QBoost = 3;
            CanBoost = false;
            animator.SetBool("Boost", true);
        }
        if (QBoost > 0)
        {
            QBoost -= Time.deltaTime * 2;
            ActualBoost = QBoost + 1;
        }
        else
        {
            QBoost = 0;
            animator.SetBool("Boost", false);
            ActualBoost = 1;
        }
        if (CanBoost == false)
        {
            NoBoostTime += Time.deltaTime;
            if (NoBoostTime > 6)
            {
                CanBoost = true;
                NoBoostTime = 0;

            }
        }


        if ((Input.GetKey("a")) && (Speed > -MaxSpeed))
        {
            Speed = Speed - Acceleration;
            transform.localScale = new Vector3(-2, 2, 0);
            animator.SetBool("idling", false);
            animator.SetBool("walking", true);
        }
        else if ((Input.GetKey("d")) && (Speed < MaxSpeed))
        {
            Speed = Speed + Acceleration;
            transform.localScale = new Vector3(2, 2, 0);

        }

        else
        {
            animator.SetBool("idling", false);
            if (Speed > Decceleration)
                Speed = Speed - Decceleration;
            else if (Speed < -Decceleration)
                Speed = Speed + Decceleration;
            else
                Speed = 0;

        }
        rb.velocity = new Vector2(Speed * ActualBoost, rb.velocity.y);

        animator.SetFloat("Speed", Mathf.Abs(Speed));



        LeftWall = Physics2D.OverlapBox(LeftPos.position, new Vector2(0.05f, 0.3f), 0f, WhatIsGround);

        if (LeftWall == true && IsGrounded == false && IsJumping == false && IsDisting == false && IsWallJumping == false || LeftWall == true && IsWallJumping == true)
        {
            if (rb.velocity.y < 0)
            {
                rb.velocity = Vector2.down * 2;
                CanDrone = false;
            }


            if (Input.GetKey(KeyCode.Space))
            {
                WallJumpTime = 2;
                // rb.velocity = Vector2.up * 15;



                if (LeftPos.position.x > FeetPos.position.x)
                {
                    // -velocity
                    Speed = -15;
                    //orig -9

                }
                else
                {
                    // + velocity
                    Speed = 15;

                    //orig 9


                }
            }
        }
        if (IsWallJumping == true)
        {
            if (LeftWall == true) { IsWallJumping = false; }
            if (IsGrounded == true) { IsWallJumping = false; }
            if (WallJumpTime < 0) { IsWallJumping = false; }
            else
            {
                WallJumpTime -= Time.deltaTime;
            }

        }
        if (rb.velocity.x > 10)
        {
            rb.velocity = new Vector2(10 * ActualBoost, rb.velocity.y);
        }
        if (rb.velocity.x < -10)
        {
            rb.velocity = new Vector2(-10 * ActualBoost, rb.velocity.y);
        }

    }

    private void Update()
    {






        IsGrounded = Physics2D.OverlapCircle(FeetPos.position, CheckRadius, WhatIsGround);


        if (IsGrounded)
        {
            Decceleration = GRNDecceleration;
            Acceleration = GRNDAcceleration;
        }
        else
        {
            Decceleration = AIRDecceleration;
            Acceleration = AIRAcceleration;
        }

        //Distorter
        if (Input.GetKeyDown(KeyCode.DownArrow) && CanDist == true && HasDist == true)
        {
            CanDist = false;
            IsDisting = true;
            animator.SetBool("Dist", true);

        }
        if (IsDisting == true)
        {
            DistTime -= Time.deltaTime;
            if (DistTime > 0)
            {
                this.GetComponent<EdgeCollider2D>().enabled = false;
            }
            else
            {
                this.GetComponent<EdgeCollider2D>().enabled = true;
                IsDisting = false;
                DistTime = DefDistTime;
            }
        }
        else
        {
            animator.SetBool("Dist", false);
            if (NoDistTime > 0)
            {
                NoDistTime -= Time.deltaTime;
            }
            else
            {
                CanDist = true;
                NoDistTime = DefNoDistTime;
            }
        }
        // Jump
        if (IsGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("Grounded", false);
            IsJumping = true;
            CanDrone = false;
            IsDroning = false;
            JumpTime = DefaultJumpTime;
            rb.velocity = Vector2.up * JumpForce;
        }
        if (Input.GetKey(KeyCode.Space) && IsJumping == true)
        {
            if (JumpTime > 0)
            {
                JumpForce = DefaultJumpForce;
                rb.velocity = Vector2.up * JumpForce;

                JumpTime -= Time.deltaTime;
                if (JumpTime < 0.4)
                {
                    JumpForce += 0.5f;
                    rb.velocity = Vector2.up * JumpForce;

                }
                if (JumpTime < 0.3)
                {
                    JumpForce -= 1f;
                    rb.velocity = Vector2.up * JumpForce;

                }
                if (JumpTime < 0.2)
                {
                    JumpForce -= 1f;
                    rb.velocity = Vector2.up * JumpForce;

                }
                if (JumpTime < 0.1)
                {
                    JumpForce -= 1f;
                    rb.velocity = Vector2.up * JumpForce;

                }
            }
            else
            {
                IsJumping = false;
                CanDrone = true;
            }



        }
        if (Input.GetKeyUp(KeyCode.Space) && IsJumping == true)
        {
            IsJumping = false;
            CanDrone = true;
        }

        if (IsGrounded == true)
        {
            DroneTime = DefaultDroneTime;
            CanDrone = true;
        }
        //Change to drone control DONE
        if (IsGrounded == false && CanDrone == true && IsJumping == false && Input.GetKeyDown(KeyCode.Space) && IsDroning == false && HasDrone == true)
        {
            animator.SetBool("Drone", true);
            IsDroning = true;
            DroneTime = DefaultDroneTime;

        }

        if (Input.GetKey(KeyCode.Space) && IsDroning == true && HasDrone == true)
        {

            DroneTime -= Time.deltaTime;
            CanDrone = false;
            animator.SetBool("Drone", true);

            if (DroneTime > 0)
            {

                rb.velocity = Vector2.up * (rb.velocity.y + JumpForce * Time.deltaTime);


                if (DroneTime < 1.5 && JumpForce < MaxForce)
                {
                    JumpForce += 0.2f;
                    rb.velocity = Vector2.up * (rb.velocity.y + JumpForce * Time.deltaTime);
                }
                if (DroneTime < 1.5 && JumpForce < MaxForce * 1.5 && rb.velocity.y < 0)
                {
                    JumpForce += 1f;
                    rb.velocity = Vector2.up * (rb.velocity.y / 2 + JumpForce * Time.deltaTime);
                }
                if (DroneTime < 1.5 && JumpForce < MaxForce * 1.5 && rb.velocity.y < 3)
                {
                    JumpForce += 1f;
                    rb.velocity = Vector2.up * (rb.velocity.y + JumpForce * Time.deltaTime);
                }
                if (DroneTime < 1.1 && JumpForce < MaxForce)

                {
                    JumpForce += 0.8f;
                    rb.velocity = Vector2.up * (rb.velocity.y + JumpForce * Time.deltaTime);

                }
                if (DroneTime < 0.7 && JumpForce < MaxForce)
                {
                    JumpForce += 0.8f;
                    rb.velocity = Vector2.up * (rb.velocity.y + JumpForce * Time.deltaTime);

                }
                if (DroneTime < 0.3 && JumpForce < MaxForce)
                {
                    JumpForce += 0.8f;
                    rb.velocity = Vector2.up * (rb.velocity.y + JumpForce * Time.deltaTime);

                }


            }
            else
            {
                IsJumping = false;
                IsDroning = false;
                CanDrone = false;




            }



        }
        else
        {
            animator.SetBool("Drone", false);
        }
        if (rb.velocity.y < -15)
            rb.velocity = Vector2.down * 15;
        if (rb.velocity.y > 15)
            rb.velocity = Vector2.up * 15;



        if (IsGrounded == true)
        {
            animator.SetBool("Grounded", true);
        }
        else
        {
            animator.SetBool("Grounded", false);
        }





        if (IsGrounded == true)
        {
            if (Speed < 0 || Speed > 0)
            {
                animator.SetBool("idling", false);
                animator.SetBool("walking", true);
                animator.SetBool("jumping", false);
                animator.SetBool("falling", false);
            }
            else
            {
                animator.SetBool("walking", false);
                animator.SetBool("idling", true);
                animator.SetBool("jumping", false);
                animator.SetBool("falling", false);
            }
        }
        else
        {
            if (rb.velocity.y > 0)
            {
                animator.SetBool("walking", false);
                animator.SetBool("idling", false);
                animator.SetBool("jumping", true);
                animator.SetBool("falling", false);

            }
            else
            {
                animator.SetBool("walking", false);
                animator.SetBool("idling", false);
                animator.SetBool("jumping", false);
                animator.SetBool("falling", true);

            }
        }
    }
}



