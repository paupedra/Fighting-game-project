using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG : MonoBehaviour
{
    // NO VARIAR SCRIPT!! SI ESO LLAMARLO DESDE OTROS SCRIPTS PARA HACER EL ANIMATOR!!!!


    // HAY DOS FLIPS DIFERENTES, YA VEREMOS CUAL MOLA MAS
    Rigidbody2D rigidbody2D;

    //------------- PUBLIC --------------

    public Transform groundCheck;          // CHILDREN QUE SERA EL OBJETO QUE LIMITE LOS PIES
    public LayerMask ground;              // LAYER QUE DETECTA QUE ES EL SUELO ( LAYEAR CADA PLATAFORMA COMO SUELO !!!!! )
    public int extraJumpsValue;           // NUMERO DE SALTOS QUE PUEDE HACER EXTRAS EN EL AIRE
    public float jumpTime;                // SEGUNDOS O MILESIMAS PARA COMPLETAR EL 100% DEL SALTO
    public float jumpForce;               // FUERZA DE SALTO
    public float speed;                   // VELOCIDAD DE MOVIMIENTO
    public float checkRadius;             // RADIO PARA MIRAR LOS PIES SI TOCAN EL SUELO
    public bool isGrounded;  
    
    //DASH---------- 
    public float maxDashTime = 5f;
    public float dashSpeed = 15f;
    public float dashStoppingSpeed = 0.1f;
    public float currentDashTime; 
    public float cdDash = 2f;              // TIEMPO DE ESPERA ENTRE DASHES
    public float cdTimer;


    //RECOVERY-------------------

    public float recoveryForce;            // FUERZA DE SALTO DE RECOVERY
    public float maxRecTime = 5f;
    public float currentRecTime; 
    public float cdRec = 2f;              // TIEMPO DE ESPERA ENTRE RECOVERYS
    public float recTimer;
        


    public bool canFlip;                  // SE UTILIZARA CUANDO LLAMEMOS EN OTROS SCRIPTS PARA ATACAR Y FREZEEAR LA ROTACION

    public bool canJump;                  // ES LLAMADO EN EL OTRO SCRIPT PARA HACER QUE NO SALTE

    public bool canDash;                  // BOOL K DIRA SI POT DASHEAR O NO

    public bool canRecovery;              // SI PUEDE O NO HACER RECOVERY
    

    //---------- PRIVATE -------------
    private int extraJumps;
    private float speedInicio;
    private float jumpTimerCounter;
    private float moveInput;
    private bool isJumping;
    private  bool facinRight = true;
    
   
    
    
    
    
    void Start()
    {
        canRecovery = true;
        canDash = true;

        currentRecTime = maxRecTime;
        currentDashTime = maxDashTime;

        canFlip = true;
        speedInicio = speed;
        extraJumps = extraJumpsValue;
        isGrounded = Physics2D.OverlapCircle(groundCheck.position,checkRadius,ground);
        rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
    }


    void Update()
    {

        //---------------------- COOLDOWN DASH --------------------------
        if(canDash == true)
        Dash();
        
        if(canDash == false){

            cdTimer += 1*Time.deltaTime;

            if(cdTimer >= cdDash){

                cdTimer = 0;
                canDash = true;

            }

        }
        //---------------------- FIN COOLDOWN DASH --------------------------

        isGrounded = Physics2D.OverlapCircle(groundCheck.position,checkRadius,ground); //CHEKA SI TOCA EL SUELO TODO EL RATO
        
        moveInput = Input.GetAxisRaw("Horizontal");

        transform.Translate(speed*Time.deltaTime*moveInput,0,0); // EL MOVIMIENTO ESKEREEEE

       
       //PUEDES USAR EL CAN FLIP 2 SI KIERES


        if(canFlip == true){
            
            if(facinRight == false && moveInput > 0){
            Flip();
        }else if(facinRight == true && moveInput < 0){
            Flip();
        }

        }
        
        if(canJump == true){
            Jump();
        }
          
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
        if(Input.GetKey(KeyCode.Space)&& isJumping == true/*&& extraJumps>0*/){ // SI QUEREMOS QUE EL SEGUNDO JUMP NO VARIE AL PULSAR MAS

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



   
// PODEMOS UTILIZARLO EN VEZ DEL OTRO
    void Flip2(){

    Vector3 characterScale = transform.localScale;
    if(Input.GetAxis("Horizontal") < 0){

        characterScale.x = -1;
    }
    if(Input.GetAxis("Horizontal") > 0){

        characterScale.x = 1;
    }
    transform.localScale = characterScale;

    }

    //DASHING AMB EL FERRARI
    void Dash(){

        if(isGrounded == true){

            if(Input.GetButton("Horizontal")){

                if(Input.GetKeyDown(KeyCode.Mouse1)){
               
                currentDashTime = 0f;

                }
                if (currentDashTime < maxDashTime)
                {
                    speed = dashSpeed;
                    currentDashTime += dashStoppingSpeed*Time.deltaTime;
            
                    if (currentDashTime >= maxDashTime){

                        speed = speedInicio;
                        canDash = false;

                    }
                }    
            }

        }
        
        if(isGrounded == false){

            speed = speedInicio;

        }
        
    }

    // LLAMADA DESDE EL SPRITE 1 DE ANIMATION RECOVERY (DESDE SCRIPT ANIMATORGUS) PARA DARLE FISICA DE SALTO
    public void Recovery(){

        rigidbody2D.velocity = Vector2.up * recoveryForce;

    }
    
}
