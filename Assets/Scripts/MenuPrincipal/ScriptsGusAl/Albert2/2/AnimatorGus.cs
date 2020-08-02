using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorGus : MonoBehaviour
{
    Animator anim;
    MG mg;
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        mg = GetComponentInParent<MG>();
        anim = GetComponent<Animator>();
        speed = mg.speed;
    }

    // Update is called once per frame
    void Update()
    {
        
        Jump();
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

        }
        if(Input.GetButtonUp("Horizontal")){

            anim.SetBool("Walk",false);

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

        if(Input.GetButtonDown("Vertical")){

            anim.SetBool("BasicAttack",false);
            anim.SetFloat("Vertical",Input.GetAxis("Vertical"));

        }
         if(Input.GetButtonUp("Vertical")){

            anim.SetBool("BasicAttack",true);
            anim.SetFloat("Vertical",0f);

        }

    }

    public void SpeedZero(){

        mg.speed = 0;
        mg.canFlip = false;


    }
    public void SpeedFull(){

        mg.speed = speed;
        mg.canFlip = true;

    }

}
