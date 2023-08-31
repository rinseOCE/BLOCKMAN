using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void ContinueGame()
    {
        SceneManager.LoadScene(1);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void GoOptions()
    {
        SceneManager.LoadScene(2);
    }
    public void ExitGame()
    {
        // Call Application.Quit() to exit the game.
        Application.Quit();
    }
}