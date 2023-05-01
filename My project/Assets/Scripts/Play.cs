using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Play : MonoBehaviour
{
    public static string userName;
    public InputField nameZone;

    public void PlayGame ()
    {
        SceneManager.LoadScene("Game");
        userName = nameZone.text;
    }
}
