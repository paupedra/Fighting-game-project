using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu( fileName = "New Char", menuName = "CharPlayer")]
public class CharPlayer : ScriptableObject
{
    public new string name;
    public Sprite spriteBase;
    public int playerNumber;

    public void Print (){

        Debug.Log(name);

    }
}
