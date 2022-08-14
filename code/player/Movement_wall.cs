using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_wall : MonoBehaviour
{
    private Rigidbody2D rb;
    public EdgeCollider2D BigCollider;
    public EdgeCollider2D SmallCollider;
    public Animator animator;
    public float Speed;
    public float MaxSpeed;
    public float Acceleration;
    public float GRNDAcceleration;
    public float AIRAcceleration;
    public bool ForceJump;
    public bool Spackd;
    public float duck;
    public bool UsedDrone;

    public float Decceleration;
    public float GRNDecceleration;
    public float AIRDecceleration;

    public float WAcceleration;
    public float WDecceleration;

    public bool IsGrounded;
    public bool LeftWall;
    
    public Transform FeetPos;
    public Transform LeftPos;
    

    public float CheckRadius;
    public LayerMask WhatIsGround;
    public float DefaultJumpForce;
    public float ForcedJumpForce;
    public float SwitchForce;
    public float JumpForce;
    float JumpTime;
    public float DefaultJumpTime;

    public float WallJump;
    public bool StickyWall;
    public float StickTime;
    public float DefaultStick;

    public float CoyoteTime;
    public float DefaultCoyote;



    public bool IsJumping;

    //Drone
    public bool CanDrone;
    public float DefaultDroneTime;
    public float MaxForce;
    public bool IsDroning;
    public bool HasDrone;
    public float DroneTime;
    public float JumpForce1;
    public float DefaultDroneForce;
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
        duck = 0;

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
        



       
        

        

        if ((Input.GetKey("a")) && (Speed > -MaxSpeed) && StickyWall == false)
        {
            if (duck == 0)
            {
                Speed = Speed - (Acceleration);
            }
            else if (IsGrounded == true)
            {
                Speed = Speed - (Acceleration / 15);
            }
            transform.localScale = new Vector3(-2, 2, 0);
            
        }
        else if ((Input.GetKey("d")) && (Speed < MaxSpeed) && StickyWall == false)
        {
            if (duck == 0)
            {
                Speed = Speed + (Acceleration);
            }
            else if (IsGrounded == true)
            {
                Speed = Speed + (Acceleration / 15);
            }
            transform.localScale = new Vector3(2, 2, 0);

        }

        else
        {
            if (IsWallJumping)
            {
                if (Speed > 6)
                {
                    Speed = 6;
                }
                else if (Speed < -6)
                {
                    Speed = -6;
                }
            }


            if (Speed > Decceleration)
                Speed = Speed - Decceleration;
            else if (Speed < -Decceleration)
                Speed = Speed + Decceleration;
            else
                Speed = 0;

        }
        if (duck == 1 && IsGrounded == true)
        {
            if (Speed > Decceleration)
                Speed = Speed - (Decceleration * 1.4f);
            else if (Speed < -Decceleration)
                Speed = Speed + (Decceleration * 1.4f);
            else
                Speed = 0;
        }

        if (WallJumpTime > 0.2 && StickyWall == false)
        {
            if ((Input.GetKey("a")))
            {
                transform.localScale = new Vector3(-2, 2, 0);
            }
            else if (Input.GetKey("d"))
            {
                transform.localScale = new Vector3(2, 2, 0);
            }
        }
        rb.velocity = new Vector2(Speed * ActualBoost, rb.velocity.y);

        animator.SetFloat("Speed", Mathf.Abs(Speed));



        LeftWall = Physics2D.OverlapBox(LeftPos.position, new Vector2(0.05f, 0.3f), 0f, WhatIsGround);

        if (LeftWall == true && IsGrounded == false && IsDisting == false && IsWallJumping == false || LeftWall == true && IsWallJumping == true)
        {

            
            
                if ((Input.GetKey("a"))|| Input.GetKey("d"))
                {
                    
                }
                else if (Input.GetKey("d") || Input.GetKey("a"))
                {
                    
                }
                else
                {
                    StickyWall = true;
                    StickTime = DefaultStick;
                }
                if (rb.velocity.y < -1)
            {
                rb.velocity = new Vector2(rb.velocity.x, -2);

            }
                
                CanDrone = false;
            


            if (Input.GetKeyDown(KeyCode.Space) || Spackd == true)
            {
                StickyWall = false;
                IsWallJumping = true;
                ForceJump = true;
                WallJumpTime = 0.5f;
                // rb.velocity = Vector2.up * 15;



                if (LeftPos.position.x > FeetPos.position.x)
                {
                    // -velocity
                    Speed = -8;
                    //orig -9

                }
                else
                {
                    // + velocity
                    Speed = 8;

                    //orig 9


                }
            }
        }

        


        if (IsWallJumping == true)
        {
            if (LeftWall == true && WallJumpTime < 0.25f)
            {
                IsWallJumping = false;
            }
            if (IsGrounded == true) { IsWallJumping = false; }
            else if (WallJumpTime < 0) { IsWallJumping = false; }
            else
            {
                WallJumpTime -= Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.Space))
            {
                if (LeftPos.position.x > FeetPos.position.x)
                {
                    // -velocity

                    Speed = Speed - (0.9f * WallJumpTime);
                    //orig -9

                }
                else
                {
                    // + velocity
                    Speed = Speed + (0.9f * WallJumpTime);

                    //orig 9

                }


                

            }
            else
            {
                
                WallJumpTime = 0;
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
        //stickywall
        if (StickyWall == true)
        {
            StickTime -= Time.deltaTime;
            if (StickTime < 0)
            {
                StickyWall = false;
            }
        }
        else if (StickTime < 0)
        {
            StickTime = DefaultStick;
        }
    }

    private void Update()
    {
        //duck
        if (Input.GetKey(KeyCode.S) && IsGrounded == true)
        {
            BigCollider.enabled = false;
            SmallCollider.enabled = true;
            duck = 1;
            animator.SetBool("ducking", true);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            BigCollider.enabled = true;
            SmallCollider.enabled = false;
            duck = 0;
            animator.SetBool("ducking", false);
        }





        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded == false)
        {
            Spackd = true;
            CoyoteTime = DefaultCoyote;
        }
        if (Spackd == true)
        {
            CoyoteTime -= Time.deltaTime;
            if (CoyoteTime < 0)
            {
                Spackd = false;

            }
        }




        IsGrounded = Physics2D.OverlapCircle(FeetPos.position, CheckRadius, WhatIsGround);


        if (IsGrounded && IsWallJumping == false)
        {
            Decceleration = GRNDecceleration;
            Acceleration = GRNDAcceleration;
        }
        else if (IsWallJumping == true)
        {
            Decceleration = WDecceleration;
            Acceleration = WAcceleration;
        }
        else
        {
            Decceleration = AIRDecceleration;
            Acceleration = AIRAcceleration;
        }
        if (duck == 1)
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
        if (IsGrounded == true && Input.GetKeyDown(KeyCode.Space) || ForceJump == true)
        {
            
            if (ForceJump == true)
            {
                SwitchForce = ForcedJumpForce;
                ForceJump = false;
            }
            else
            {
                SwitchForce = DefaultJumpForce;
            }
            
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
                JumpForce = SwitchForce;
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
            IsDroning = false;
            DroneTime = DefaultDroneTime;
            CanDrone = true;
            UsedDrone = false;
        }
        //Change to drone control DONE
        if (IsGrounded == false && CanDrone == true && IsJumping == false && Input.GetKeyDown(KeyCode.Space) && IsDroning == false && HasDrone == true)
        {
            animator.SetBool("Drone", true);
            IsDroning = true;
            UsedDrone = true;
            DroneTime = DefaultDroneTime;
            JumpForce1 = DefaultDroneForce;

        }

        if (Input.GetKey(KeyCode.Space) && IsDroning == true && HasDrone == true)
        {

            DroneTime -= Time.deltaTime;
            CanDrone = false;
            
            animator.SetBool("Drone", true);

            if (DroneTime > 0)
            {

                rb.velocity = Vector2.up * (rb.velocity.y + JumpForce1 * Time.deltaTime);


                if (DroneTime < 1.5 && JumpForce1 < MaxForce)
                {
                    JumpForce1 += 0.2f;
                    rb.velocity = Vector2.up * (rb.velocity.y + JumpForce1 * Time.deltaTime);
                }
                if (DroneTime < 1.5 && JumpForce1 < MaxForce * 1.5 && rb.velocity.y < 0)
                {
                    JumpForce1 += 1f;
                    rb.velocity = Vector2.up * (rb.velocity.y / 2 + JumpForce1 * Time.deltaTime);
                }
                if (DroneTime < 1.5 && JumpForce1 < MaxForce * 1.5 && rb.velocity.y < 3)
                {
                    JumpForce1 += 1f;
                    rb.velocity = Vector2.up * (rb.velocity.y + JumpForce1 * Time.deltaTime);
                }
                if (DroneTime < 1.1 && JumpForce1 < MaxForce)

                {
                    JumpForce1 += 0.5f;
                    rb.velocity = Vector2.up * (rb.velocity.y + JumpForce1 * Time.deltaTime);

                }
                if (DroneTime < 0.7 && JumpForce1 < MaxForce)
                {
                    JumpForce1 += 0.5f;
                    rb.velocity = Vector2.up * (rb.velocity.y + JumpForce1 * Time.deltaTime);

                }
                if (DroneTime < 0.3 && JumpForce1 < MaxForce)
                {
                    JumpForce1 += 0.5f;
                    rb.velocity = Vector2.up * (rb.velocity.y + JumpForce1 * Time.deltaTime);

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
            if (rb.velocity.y > -0.2f)
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



