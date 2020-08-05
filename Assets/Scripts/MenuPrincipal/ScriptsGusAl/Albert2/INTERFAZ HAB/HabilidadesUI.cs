using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HabilidadesUI : MonoBehaviour
{
    MG mG;
    AnimatorGus aG;
    public Image DashImg;
    public Image RecImg;
    // Start is called before the first frame update
    void Start()
    {
        DashImg.color = Color.green;
        RecImg.color = Color.green;
        mG = GameObject.FindGameObjectWithTag("Player").GetComponent<MG>();
        aG = GameObject.FindGameObjectWithTag("Graphic").GetComponent<AnimatorGus>();
    }

    // Update is called once per frame
    void Update()
    {
        if(mG.canRecovery == false){

            RecImg.color = Color.red;

        }

        if(mG.canDash == false){

            DashImg.color = Color.red;

        }

         if(mG.canRecovery == true){

            RecImg.color = Color.green;

        }

        if(mG.canDash == true){

            DashImg.color = Color.green;

        }
    }
}
