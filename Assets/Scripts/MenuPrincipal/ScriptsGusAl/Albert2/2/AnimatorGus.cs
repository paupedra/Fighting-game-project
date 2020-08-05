using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorGus : MonoBehaviour
{

    // COSES A FER ---------- Recovery:(Estar en el aire + LMB + W)--------------------- FETTTTTTT

    // ORGANITZAR UNA MICA MILLOR ELS SCIRPTS!!!!


    Animator anim;
    MG mg;
    private float speed;
    private float roundUpV;
    private bool canWalk;

    // Start is called before the first frame update
    void Start()
    {
        mg = GetComponentInParent<MG>();
        anim = GetComponent<Animator>();
        speed = mg.speed;
        anim.SetBool("BasicAttack",true);
        canWalk = true;
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Dash();
        Recovery();
        
        if(canWalk == true)
        Walk();

        Attack();
        Vertical();
    }

    void Jump(){

        if(mg.isGrounded == true){

            anim.SetBool("isGrounded",true);

        }
        if(mg.isGrounded == false){

            anim.SetBool("isGrounded",false);

        }
    }
    void Walk(){

         if(Input.GetButton("Horizontal")){

            anim.SetBool("Walk",true);
            anim.SetBool("BasicAttack",false);
            

        }
        if(Input.GetButtonUp("Horizontal")){

            anim.SetBool("Walk",false);
            anim.SetBool("BasicAttack",true);

        }
    }
    void Attack(){

        if(Input.GetButtonDown("Attack")){


            anim.SetBool("Attack",true);

        }
        if(Input.GetButtonUp("Attack")){


            anim.SetBool("Attack",false);

        }

    }

    void Vertical(){

        if(Input.GetKeyDown(KeyCode.W)){

            roundUpV = 1;

        }
        
        if(Input.GetKeyDown(KeyCode.S)){

            if(mg.isGrounded == true){

                anim.SetBool("Crouch",true);

                //anim.SetBool("Walk",false);

            }
            
            roundUpV = -1;

        }
        
        if(Input.GetButton("Vertical")){

            if(mg.isGrounded == true){

               // canWalk = false;
                anim.SetBool("Walk",false);

            }

            anim.SetBool("BasicAttack",false);

        }
        
        if(Input.GetButtonDown("Vertical")){
        
            anim.SetBool("BasicAttack",false);
            anim.SetFloat("Vertical",roundUpV);

        }
         if(Input.GetButtonUp("Vertical")){

            anim.SetBool("BasicAttack",true);
            anim.SetFloat("Vertical",0f);
            anim.SetBool("Crouch",false);
            
            //canWalk = true;

        }

    }

    void Dash(){
        
        if(mg.canDash == true){

            if(Input.GetButton("Horizontal")){

            if(Input.GetKeyDown(KeyCode.Mouse1)){

                anim.SetBool("Dash",true);

            }

            }

        }

    }


    // CADA VEZ QUE TOCA EL SUELO PUEDE VOLVER A UTILIZARLO

    //----------------- FALTA HACER QUE PASE LO MIsMO cADA VEZ K ES HITEADO-----------
    void Recovery(){

        if(Input.GetKeyDown(KeyCode.Mouse1)){

            if(mg.canRecovery == true){

                anim.SetBool("Recovery",true);

            } 

        }
        if(mg.isGrounded == true){

            mg.canRecovery = true;

        }

        if(mg.canRecovery == false){

                anim.SetBool("Recovery",false);

            } 

        /*// TIMER RECOVERY PER TORNAR A FERHO EN UNS SEGS
         if(mg.canRecovery == false){

                anim.SetBool("Recovery",false);
                mg.recTimer += 1*Time.deltaTime;

            if(mg.recTimer >= mg.cdRec){

                mg.recTimer = 0;
                mg.canRecovery = true;

            }

            }*/

    }

    public void SpeedZero(){

        anim.SetBool("Walk",false);
        canWalk = false;
        mg.speed = 0;
        mg.canFlip = false;
        mg.canJump = false;


    }

    // FINAL DE TOTS BASICOS LATERAL ( PENULTIM FRAME)
    public void CanBasickAttack(){

        anim.SetBool("BasicAttack",true);
        canWalk = true;

    }

    public void SpeedFull(){

        canWalk = true;
        mg.speed = speed;
        mg.canFlip = true;
        mg.canJump = true;

    }

    public void SpeedFullEnIdle(){

        if(Input.GetAxis("Vertical") == 0)
        anim.SetBool("BasicAttack",true);


        canWalk = true;
        mg.speed = speed;
        mg.canFlip = true;
        mg.canJump = true;

    }

    public void FinalDash(){

        anim.SetBool("Dash",false);

    }

    // ACTIVA FISICAS RECOVERY EN MG PER DONAR IMPULS DESDE FRAME 1 ANIMACIO
    public void RecoveryFisics(){

        mg.Recovery();

    }

    public void FinalRecovery(){

        mg.canRecovery = false;
        //mg.canDash = false;

    }

}
