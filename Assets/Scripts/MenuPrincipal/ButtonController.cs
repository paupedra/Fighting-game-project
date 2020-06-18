using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{   
    public Canvas MainMenu;
    public Canvas PlayMenu;
    public Canvas Options;
    public Canvas CharSelectLocal;
    public Canvas CharSelectOnline;
    public Canvas CharselectIA;
    // Start is called before the first frame update
    void Start()
    {
        PlayMenu.enabled = false;
        Options.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
   //MENU SETTINGS
   
    public void InicioToPlay(){

        MainMenu.enabled = false;
        Options.enabled = false;
        CharSelectLocal.enabled = false;

        PlayMenu.enabled = true;

    }
    
    public void ReturnToMainMenu(){

        //disable the canvas exept MainMenu
        PlayMenu.enabled = false;
        Options.enabled = false;
        CharSelectLocal.enabled = false;

        MainMenu.enabled = true;

    }

    public void InicioToOpcions(){

        MainMenu.enabled = false;
        PlayMenu.enabled = false;
        CharSelectLocal.enabled = false;
        
        Options.enabled = true;

    }

    public void PlayCharToPrev(){

        MainMenu.enabled = false;
        Options.enabled = false;
        CharSelectLocal.enabled = false;
        
        PlayMenu.enabled = true;

    }






    //PLAY MODE
    
    public void PlayToChoseCharVsOnline(){

        MainMenu.enabled = false;
        PlayMenu.enabled = false;
        Options.enabled = false;
        CharSelectLocal.enabled = false;

    }
     public void PlayToChoseCharVsLocal(){

        MainMenu.enabled = false;
        PlayMenu.enabled = false;
        Options.enabled = false;

        CharSelectLocal.enabled = true;

    }
     public void PlayToChoseCharVsIA(){

        MainMenu.enabled = false;
        PlayMenu.enabled = false;
        Options.enabled = false;
        CharSelectLocal.enabled = false;


    }
}
