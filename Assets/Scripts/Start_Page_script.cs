using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Page_script : MonoBehaviour
{
    public void onPressStart()
    {
        SceneManager.LoadScene(0);
    }

    public void onPressQuit()
    {
        Application.Quit();
    }

    public void onPressTryAgain()
    {
        SceneManager.LoadScene(1);
    }
}
