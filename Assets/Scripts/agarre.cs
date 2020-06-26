using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//falta crear bool script movement para si salta o no el marico
public class agarre : MonoBehaviour
{
    public Rigidbody2D rg;
    bool puedeSalir = true;

    void Update()
    {
        SalirAgarre();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="borde")
        rg.isKinematic = true;
        puedeSalir = false;
        if(puedeSalir == false)
        {
            rg.constraints = RigidbodyConstraints2D.FreezePositionY;
            rg.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "borde")
            rg.isKinematic = false;
        
    }
    private void SalirAgarre()
    {
        if(Input.GetButtonDown("Horizontal") || Input.GetKeyDown(KeyCode.Space))
        {
            puedeSalir = true;
            rg.constraints = RigidbodyConstraints2D.None;
            rg.constraints = RigidbodyConstraints2D.FreezeRotation;
            rg.isKinematic = false;
        }
    }
}
