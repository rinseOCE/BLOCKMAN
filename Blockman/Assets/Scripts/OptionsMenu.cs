using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    public void GoBack()
    {
        SceneManager.LoadScene(0);
    }
    public void PausedGoBack()
    {
        SceneManager.LoadScene(1);
    }
}
