using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void GoOptions()
    {
        SceneManager.LoadScene(2);
    }
    public void GoCredits()
    {
        SceneManager.LoadScene(3);
    }

    public void GoSettings()
    {
        SceneManager.LoadScene(4);
    }
    public void ExitGame()
    {
        // Call Application.Quit() to exit the game.
        Application.Quit();
    }
}
