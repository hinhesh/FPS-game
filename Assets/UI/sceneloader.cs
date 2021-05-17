using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneloader : MonoBehaviour
{
    public void reloadGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
