using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Author: Andrew Seba
/// </summary>
public class MainMenuButtons : MonoBehaviour {

    const string MAINMENU = "MainMenu";
    const string GAMESTART = "GameStart";

    public void _StartGame()
    {
        SceneManager.LoadScene(GAMESTART);
    }

    

    public void _QuitGame()
    {
        Application.Quit();
    }
}
