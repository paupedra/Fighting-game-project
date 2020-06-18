using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementChar : MonoBehaviour
{
    public CharController controller;
    public Animator animator;

    enum StateMachine
    {
        IDLE = 0,
        JUMPING,
        CROUCHING,
        PUCHING,
        HURT
    }

    StateMachine state = StateMachine.IDLE;

    //FrameRate vars
    

    public float runSpeed = 0f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    public Rigidbody2D rigidbody2D;

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        UpdateAnimations(); //Animator variables

        //switch(state)
        //{
        //    case StateMachine.IDLE:
        //        break;

        //    case StateMachine.JUMPING:
        //        break;

        //    case StateMachine.CROUCHING:
        //        break;

        //    case StateMachine.PUCHING:
        //        break;

        //    case StateMachine.HURT:
        //        break;
        //}

        if (Input.GetButtonDown("Jump"))
        {
            state = StateMachine.JUMPING;
        }


        if (Input.GetAxisRaw("Vertical") < 0) //Input.GetButtonDown("Down")
        {
            crouch = true;
        }

        if(Input.GetButtonDown("Punch"))
        {

        }

    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
        crouch = false;
    }

    void UpdateAnimations()
    {
        //Brakeys stuff
        animator.SetFloat("speed", Mathf.Abs(horizontalMove));
        animator.SetFloat("velocityY", rigidbody2D.velocity.y);
        animator.SetBool("isGrounded", controller.grounded);

        //Increse frame 

    }
}
