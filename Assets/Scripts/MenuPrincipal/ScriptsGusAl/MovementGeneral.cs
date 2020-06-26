using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementGeneral : MonoBehaviour
{ 
    Rigidbody2D rigidbody2D;
    public Transform groundCheck;
    public LayerMask ground;


    public int extraJumpsValue;
    public float jumpForce;
    public float speed;
    public float checkRadius;
    public float jumpTime;
    public bool canFlip;
    public bool isGrounded;


    private int extraJumps;
    private float speedInicio;
    private float jumpTimerCounter;
    private float moveInput;
    private bool isJumping;
    private  bool facinRight = true;
    

    void Start()
    {
        canFlip = true;
        speedInicio = speed;
        extraJumps = extraJumpsValue;
        isGrounded = Physics2D.OverlapCircle(groundCheck.position,checkRadius,ground);
        rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position,checkRadius,ground);

        moveInput = Input.GetAxisRaw("Horizontal");

        transform.Translate(speed*Time.deltaTime*moveInput,0,0);

        
        if (canFlip == true){

            if(facinRight == false && moveInput > 0){
            Flip();
        }else if(facinRight == true && moveInput < 0){
            Flip();
        }
        }

        Jump();

    }

   
   
    void Jump(){

        if ( isGrounded == true){

            extraJumps = extraJumpsValue;

        }

        if ( Input.GetKeyDown(KeyCode.Space)&&extraJumps > 0){
            isJumping = true;
            jumpTimerCounter = jumpTime;
            rigidbody2D.velocity = Vector2.up * jumpForce;
            extraJumps --;
        }else if (Input.GetKeyDown(KeyCode.Space)&& extraJumps == 0&& isGrounded == true){
            rigidbody2D.velocity = Vector2.up * jumpForce;
        }
                                                            // SI QUEREMOS QUE EL SEGUNDO JUMP NO VARIE AL PULSAR MAS
        if(Input.GetKey(KeyCode.Space)&& isJumping == true/*&& extraJumps>0*/){

            if(jumpTimerCounter > 0){
                 rigidbody2D.velocity = Vector2.up * jumpForce;
                 jumpTimerCounter -= Time.deltaTime;
            }else{
                isJumping = false;
            }
            
        }
        if (Input.GetKeyUp(KeyCode.Space)){
            isJumping = false;

        }

    }

    void Flip(){
  
    facinRight =! facinRight;
    Vector3 Scaler = transform.localScale;
    Scaler.x *= -1;
    transform.localScale = Scaler;

    }
    
}
