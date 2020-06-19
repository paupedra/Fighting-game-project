using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class MovementChar : MonoBehaviour
{
    //Rigidbody
    private Rigidbody2D rigidbody2D;

    //Ground Check
    [SerializeField] private LayerMask groundLayer;                          // A mask determining what is ground to the character
    [SerializeField] private Transform groundCheckPoint;                     // A position marking where to check if the player is grounded.
    [SerializeField] private Transform ceilingCheckPoint;                    // A position marking where to check for ceilings
    const float groundedRadius = .1f;                                        // Radius of the overlap circle to determine if grounded
    public bool grounded = false;                                            // Whether or not the player is grounded.
    bool wasGrounded = false;
    
    const float ceilingRadius = .2f;                                         // Radius of the overlap circle to determine if the player can stand up

    public Animator animator;

    [SerializeField] private float jumpVelocity = 7;                          // Amount of force added when the player jumps.
    [Range(0, 1)] [SerializeField] private float crouchSpeed = .36f;          // Amount of maxSpeed applied to crouching movement. 1 = 100%
    [Range(0, .3f)] [SerializeField] private float movementSmoothing = .05f;  // How much to smooth out the movement
    [SerializeField] private bool airControl = false;                         // Whether or not a player can steer while jumping;
    
    [SerializeField] private Collider2D standingCollider;                // A collider that will be disabled when crouching
   
    private bool facingRight = true;  // For determining which way the player is currently facing.
    private Vector3 velocity = Vector3.zero;

   // [Space]

    private bool wasCrouching = false;

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

    public float runSpeed = 0f;
    float horizontalMove = 0f;

    void Update()
    {
        GroundedCheck(); //Check if character is grounded

        horizontalMove = Input.GetAxis("Horizontal") * runSpeed;

        //Animator variables

        switch (state)
        {
            case StateMachine.IDLE:

                 if(Input.GetButtonDown("Jump") && grounded) //Starts jump, break from switch
                 {
                    state = StateMachine.JUMPING;
                    StartJump();

                    break;
                 }

                 if(Input.GetAxisRaw("Horizontal") != 0) //If no other input has been recieved run
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

                    break;
                }

                if (Input.GetAxisRaw("Horizontal") == 0) //If no other input has been recieved run
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
                }

                break;

            case StateMachine.LANDING:

                state = StateMachine.IDLE;

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
        animator.SetFloat("speed", Mathf.Abs(horizontalMove));
        animator.SetFloat("velocityY", rigidbody2D.velocity.y);
        animator.SetBool("isGrounded", grounded);

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
            }
        }
    }

    void StartJump()
    {
        rigidbody2D.velocity = Vector2.up * jumpVelocity;
    }

    void Jumping()
    {

    }

    void Run()
    {
        rigidbody2D.transform.Translate(Input.GetAxis("Horizontal") * runSpeed * Time.deltaTime, 0, 0);

    }

    void Flip()
    {
        Vector3 modifiedScale = transform.localScale;
        modifiedScale.x *= -1;
        rigidbody2D.transform.localScale = modifiedScale;
    }
}
