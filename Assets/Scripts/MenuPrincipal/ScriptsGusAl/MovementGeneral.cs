using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementGeneral : MonoBehaviour
{

    Animator anim; 
    Rigidbody2D rigidbody2D;
    public float jumpForce;
    public float speed;
    
    private int extraJumps;
    public int extraJumpsValue;


    private bool isGrounded;
    private float speedInicio;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask ground;

    private float jumpTimerCounter;
    public float jumpTime;
    private bool isJumping;
    
    //PUDER LA NECESITO
    public bool canFlip;



    private float moveInput;
    private  bool facinRight = true;
    // Start is called before the first frame update
    void Start()
    {
        canFlip = true;
        speedInicio = speed;
        //anim = GetComponentInChildren<Animator>();
        extraJumps = extraJumpsValue;
        isGrounded = Physics2D.OverlapCircle(groundCheck.position,checkRadius,ground);
        rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position,checkRadius,ground);
        moveInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(speed*Time.deltaTime*moveInput,0,0);
        //------------SIEMPRE QUE ATAQUE NO PODRA FLIPEAR, AHORA PARECE BUG EN ANIMATOR PERO ES PORK NO HAY EVENTOS EN FINAL DE ANIMACIONES


        // COLOCAR EVENTO AL FINAL DE CADA ANIMACION DONDE PUEDA VOLVER A FLIPEAR EL PJ
        if(Input.GetButtonDown("Attack")){
            canFlip = false;
    
        }
        if(Input.GetButtonUp("Attack")){
            anim.SetBool("Attack",false);
        }
        if (canFlip == true){

            if(facinRight == false && moveInput > 0){
            Flip();
        }else if(facinRight == true && moveInput < 0){
            Flip();
        }
        }

        Jump();

        AnimWalk();

        Attack();

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

    void AnimWalk(){

        if(Input.GetButton("Horizontal")||Input.GetButton("Vertical")){

            anim.SetBool("Walk",true);

        }
        if(/*Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical")== 0*/Input.GetButtonUp("Horizontal")){

            anim.SetBool("Walk",false);

        }
        if(isGrounded == true){

            anim.SetBool("IsGrounded",true);

        }
        if(isGrounded == false){

            anim.SetBool("IsGrounded",false);

        }

    }

    void Attack(){

            // ------------------------ RETOCAR TODO ESTO --------------------------
        if(Input.GetButtonDown("Attack")){

            if(anim.GetBool("Walk")== true){

                anim.SetBool("Attack",false);

            }
            if(isGrounded == false){
            anim.SetBool("AirAttack",true);
            }
            
            if(Input.GetButton("Horizontal")||Input.GetButton("Vertical")){

               // anim.SetBool("Attack",true);

            if(Input.GetButtonDown("Attack")&&isGrounded == true){

                anim.SetBool("AttackLateral",true);
                canFlip = false;

            }
            

        }
        if(anim.GetBool("AttackLateral")== true){

                anim.SetBool("Attack",false);

            }
            
            if(anim.GetBool("AirAttack")== false || anim.GetBool("AttackLateral")== false){

                anim.SetBool("Attack",true);
            }
            
            //speed = 0;
        } 

    }
    
}
