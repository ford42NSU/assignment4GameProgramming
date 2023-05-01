using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static wordManager;

public class Quit : MonoBehaviour
{
    public void QuitGame()
    {
        SceneManager.LoadScene("Exit");
    }

    void Update ()
    {
        if (lives < 1)
        {
            QuitGame();
        }
    }
}
