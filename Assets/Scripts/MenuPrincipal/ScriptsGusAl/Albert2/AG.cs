using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AG : MonoBehaviour
{
    Animator anim;
    MG mg;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        mg = GetComponentInParent<MG>();
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
        Jump();
    }

    void Walk(){

        if(Input.GetButton("Horizontal")){

            anim.SetBool("Walk",true);

        }
        if(Input.GetButtonUp("Horizontal")){

            anim.SetBool("Walk",false);

        }

    }
    void Jump(){

        if(mg.isGrounded == true){

            anim.SetBool("IsGrounded",true);

        }
        if(mg.isGrounded == false){

            anim.SetBool("IsGrounded",false);

        }

    }
}
