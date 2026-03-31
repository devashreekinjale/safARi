using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenController : MonoBehaviour
{
    public void HomePage()
    {
        SceneManager.LoadScene("HomePage");
    }

    public void ARScene()
    {
        SceneManager.LoadScene("ARScene");
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
