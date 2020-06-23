using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControllerGus : MonoBehaviour
{
    private float speedInicio;
    MovementGeneral MG;
    Animator anim;
    Rigidbody2D rb;
    // ---------------------------SCRIPT DE PRUEBAS -----------------------------
    void Start()
    {
        rb = GetComponentInParent<Rigidbody2D>();
        MG = GetComponentInParent<MovementGeneral>();
        anim = GetComponentInParent<Animator>();
        speedInicio = MG.speed;
    }


     public void InicioAttack(){
        
        MG.speed = 0;
        MG.canFlip = false;

    }

    public void FinalAttack(){

        MG.speed = speedInicio;
        anim.SetBool("Attack",false);
        MG.canFlip = true;
    
    }
    public void CanFlip(){

        MG.canFlip = true;
        MG.speed = speedInicio;

    }

    public void FinalAttackLateral(){

        MG.speed = speedInicio;
        anim.SetBool("AttackLateral",false);
        MG.canFlip = true;

    }

    public void FinalAttackAir(){

        MG.canFlip = true;
        anim.SetBool("AirAttack",false);

    }

}
