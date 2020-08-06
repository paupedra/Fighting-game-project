using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botones : MonoBehaviour
{
    public List <Canvas> menus = new List<Canvas>();

    private void Start()
    {
        menus[0].enabled = true;
        menus[1].enabled = false;
        menus[2].enabled = false;
        menus[3].enabled = false;
        menus[4].enabled = false;
    }
    /*
    0 inicio
    1 play
    2 options
    3 charSelect
    4 mapSelect
    */
    public void InicioToPlay()
    {
        menus[0].enabled = false;
        menus[1].enabled = true;
        menus[2].enabled = false;
        menus[3].enabled = false;
        menus[4].enabled = false;
    }
    public void InicioToOptions()
    {
        menus[0].enabled = false;
        menus[1].enabled = false;
        menus[2].enabled = true;
        menus[3].enabled = false;
        menus[4].enabled = false;
    }

    /*
    public void InicioToPlay()
    {

        MainMenu.enabled = false;
        Options.enabled = false;
        CharSelectLocal.enabled = false;

        PlayMenu.enabled = true;

    }

    public void ReturnToMainMenu()
    {

        //disable the canvas exept MainMenu
        PlayMenu.enabled = false;
        Options.enabled = false;
        CharSelectLocal.enabled = false;
        MapSelection.enabled = false;

        MainMenu.enabled = true;

    }

    public void InicioToOpcions()
    {

        MainMenu.enabled = false;
        PlayMenu.enabled = false;
        CharSelectLocal.enabled = false;
        MapSelection.enabled = false;

        Options.enabled = true;

    }

    public void PlayCharToPrev()
    {

        MainMenu.enabled = false;
        Options.enabled = false;
        CharSelectLocal.enabled = false;
        MapSelection.enabled = false;

        PlayMenu.enabled = true;

    }
    public void PlayerCharSelectToMap()
    {

        MainMenu.enabled = false;
        Options.enabled = false;
        CharSelectLocal.enabled = false;
        PlayMenu.enabled = false;

        MapSelection.enabled = true;

    }
    public void MapSelectToCharLocal()
    {

        MapSelection.enabled = false;
        MainMenu.enabled = false;
        Options.enabled = false;
        PlayMenu.enabled = false;

        CharSelectLocal.enabled = true;

    }
    */
}
