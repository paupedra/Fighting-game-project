using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG : MonoBehaviour
{
    // NO VARIAR SCRIPT!! SI ESO LLAMARLO DESDE OTROS SCRIPTS PARA HACER EL ANIMATOR!!!!

    Animator anim;
    Rigidbody2D rigidbody2D;

    //------------- PUBLIC --------------

    public Transform groundCheck;          // CHILDREN QUE SERA EL OBJETO QUE LIMITE LOS PIES
    public LayerMask ground;              // LAYER QUE DETECTA QUE ES EL SUELO ( LAYEAR CADA PLATAFORMA COMO SUELO !!!!! )
    public int extraJumpsValue;           // NUMERO DE SALTOS QUE PUEDE HACER EXTRAS EN EL AIRE
    public float jumpTime;                // SEGUNDOS O MILESIMAS PARA COMPLETAR EL 100% DEL SALTO
    public float jumpForce;               // FUERZA DE SALTO
    public float speed;                   // VELOCIDAD DE MOVIMIENTO
    public float checkRadius;             // RADIO PARA MIRAR LOS PIES SI TOCAN EL SUELO
    

    //---------- PRIVATE -------------
    private int extraJumps;
    private float speedInicio;
    private float jumpTimerCounter;
    private float moveInput;
    private bool isJumping;
    private bool isGrounded;
    private  bool facinRight;
    
    
    
    
    void Start()
    {
        facinRight = true;
        speedInicio = speed;
        anim = GetComponentInChildren<Animator>();    // LO LLEVARA EL CHILDREN GRAPHIC O COMO SE LLAME EL QUE LLEVA LOS SPRITES
        extraJumps = extraJumpsValue;
        isGrounded = Physics2D.OverlapCircle(groundCheck.position,checkRadius,ground);
        rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position,checkRadius,ground); //CHEKA SI TOCA EL SUELO TODO EL RATO
        
        moveInput = Input.GetAxisRaw("Horizontal");

        transform.Translate(speed*Time.deltaTime*moveInput,0,0); // EL MOVIMIENTO ESKEREEEE

       
       //DONDE CHEKA SI TIENE K FLIPEAR O NO
        if(facinRight == false && moveInput > 0){
            Flip();
        }else if(facinRight == true && moveInput < 0){
            Flip();
        }
        
        Jump();
        
    }


    // ESTA VOID HACE QUE PEUDAS FLIPEAR EL PERSONAJE AL CAMBIAR DE DIRECCION ( REESCALA EN -1 Y VICEVERSA )
     void Flip(){
  
    facinRight =! facinRight;
    Vector3 Scaler = transform.localScale;
    Scaler.x *= -1;
    transform.localScale = Scaler;

    }

    
    
    
    
    
    // YA LO DICE EL NOMBRE XDD
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


}
