using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu( fileName = "New Char", menuName = "Char")]
public class Characters : ScriptableObject
{
    public new string name;
    public Sprite artwork;
    public int playerNumber;

    public void Print (){

        Debug.Log(name);

    }
}
