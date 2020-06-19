using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharDisplay : MonoBehaviour
{

    public Characters characters;
    public TMP_Text nameText;

    public Sprite artworkImage;
    // Start is called before the first frame update
    void Start()
    {
        //characters.Print();

        nameText.text = characters.name;
        this.gameObject.GetComponent<Image>().sprite = artworkImage;
    }
}
