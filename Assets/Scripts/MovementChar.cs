using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementChar : MonoBehaviour
{
    public CharController controller;
    public Animator animator;

    public float runSpeed = 0f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    public Rigidbody2D rigidbody2D;

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;


        UpdateAnimations();

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetAxisRaw("Vertical") < 0) //Input.GetButtonDown("Down")
        {
            crouch = true;
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
        animator.SetFloat("speed", Mathf.Abs(horizontalMove));
        animator.SetFloat("velocityY", rigidbody2D.velocity.y);
        animator.SetBool("isGrounded", controller.m_Grounded);
    }
}
