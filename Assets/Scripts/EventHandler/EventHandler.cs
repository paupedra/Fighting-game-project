using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EventHandler : MonoBehaviour
{

    public MovementChar characterController;

    

    // Start is called before the first frame update
    void Start()
    {
        characterController = GameObject.FindGameObjectWithTag("Player").GetComponent<MovementChar>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void finishAttackCall()
    {
        characterController.finishAttack();
    }
}
