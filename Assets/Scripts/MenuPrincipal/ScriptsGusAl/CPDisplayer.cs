using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CPDisplayer : MonoBehaviour
{

    public CharPlayer CP;
    public Sprite spriteOG;
    // Start is called before the first frame update
    void Start()
    {
        spriteOG = CP.spriteBase;
        this.gameObject.GetComponent<SpriteRenderer>().sprite = spriteOG;
    }

    
}
