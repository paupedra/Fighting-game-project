using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class MovementChar : MonoBehaviour
{
    //Rigidbody
    private Rigidbody2D rigidbody2D;

    //Animator
    public Animator animator;

    //Ground Check
    [SerializeField] private LayerMask groundLayer;                          // A mask determining what is ground to the character
    [SerializeField] private Transform groundCheckPoint;                     // A position marking where to check if the player is grounded.
    [SerializeField] private Transform ceilingCheckPoint;                    // A position marking where to check for ceilings
    const float groundedRadius = .1f;                                        // Radius of the overlap circle to determine if grounded
    public bool grounded = false;                                            // Whether or not the player is grounded.
    bool wasGrounded = false;

    //Landing
    float landingTimer = 0f;
    bool landing = false;

    //Movement vars
    bool jumping = false;
    [SerializeField] private float jumpVelocity = 7;                          // Amount of force added when the player jumps.
    [Range(0, 1)] [SerializeField] private float crouchSpeed = .36f;          // Amount of maxSpeed applied to crouching movement. 1 = 100%
    [Range(0, .3f)] [SerializeField] private float movementSmoothing = .05f;  // How much to smooth out the movement

    public float runSpeed = 0f;
    float horizontalMove = 0f;

    [SerializeField] private Collider2D standingCollider;                // A collider that will be disabled when crouching
   
    private bool facingRight = true;  // For determining which way the player is currently facing.

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

        //if (OnLandEvent == null)
        //    OnLandEvent = new UnityEvent();

        //if (onCrouchEvent == null)
        //    onCrouchEvent = new BoolEvent();
    }
    enum StateMachine
    {
        IDLE = 0,
        RUNNING,
        JUMPING,
        LANDING,
        CROUCHING,
        PUNCHING,
        HURT
    }

    StateMachine state = StateMachine.IDLE;

    void Update()
    {
        GroundedCheck(); //Check if character is grounded

        switch (state)
        {
            case StateMachine.IDLE:

                if (Input.GetButtonDown("Jump") && grounded) //Starts jump, break from switch
                {
                    state = StateMachine.JUMPING;
                    StartJump();
                }
                else if (Input.GetAxisRaw("Horizontal") != 0) //If no other input has been recieved run
                {
                   state = StateMachine.RUNNING;
                }

                break;

            case StateMachine.RUNNING:

                Run();

                if (Input.GetButtonDown("Jump") && grounded) //Starts jump, break from switch
                {
                    state = StateMachine.JUMPING;
                    StartJump();
                }
                else if (Input.GetAxisRaw("Horizontal") == 0) //If no other input has been recieved run
                {
                    state = StateMachine.IDLE;
                }

                break;

            case StateMachine.JUMPING:

                Jumping();

                Run();

                if(grounded)
                {
                    state = StateMachine.LANDING;
                    landing = true;
                }

                break;

            case StateMachine.LANDING:

                Landing(0.125f);

                break;

            case StateMachine.CROUCHING:
                break;

            case StateMachine.PUNCHING:
                break;

            case StateMachine.HURT:
                break;
        }

        UpdateAnimations();
    }

    void FixedUpdate()
    {
        //controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
    }

    void UpdateAnimations()
    {
        //Brakeys stuff
        animator.SetFloat("xVelocity", Input.GetAxisRaw("Horizontal"));
        animator.SetFloat("yVelocity", rigidbody2D.velocity.y);
        animator.SetBool("isGrounded", grounded);
        animator.SetBool("landing", landing);

        //Increse frame 

    }

    void GroundedCheck()
    {
        wasGrounded = grounded;
        grounded = false;

        if(rigidbody2D.velocity.y > 0)
        {
            return;
        }

        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheckPoint.position, groundedRadius, groundLayer);

        for(int i =0; i < colliders.Length; ++i)
        {
            if(colliders[i].gameObject != gameObject) //If it's not the character game object
            {
                grounded = true;
                jumping = false;
            }
        }
    }

    void StartJump()
    {
        rigidbody2D.velocity = Vector2.up * jumpVelocity;

        jumping = true;
    }

    void Jumping()
    {

    }

    void Run()
    {
        rigidbody2D.transform.Translate(Input.GetAxis("Horizontal") * runSpeed * Time.deltaTime, 0, 0);

        if(!jumping)
        {
            if(facingRight && Input.GetAxisRaw("Horizontal") < 0)
            {
                Flip();
                facingRight = false;
            }
            else if(!facingRight && Input.GetAxisRaw("Horizontal") > 0)
            {
                Flip();
                facingRight = true;
            }
        }
    }

    void Landing(float duration)
    {
        landingTimer += Time.deltaTime;
        

        if(landingTimer >= duration)
        {
            state = StateMachine.IDLE;
            landingTimer = 0f;
            landing = false;
        }
    }

    void Flip()
    {
        Vector3 modifiedScale = transform.localScale;
        modifiedScale.x *= -1;
        rigidbody2D.transform.localScale = modifiedScale;
    }
}
