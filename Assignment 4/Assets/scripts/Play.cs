using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Play : MonoBehaviour
{   
    public static string Names;
    public static float traffic;
    public static float speed;

    public Slider trafficSource;
    public Slider speedSource;
    public InputField nameSource;

    public void play()
    {
        Names = nameSource.text;
        speed = speedSource.value;
        traffic = trafficSource.value;

        SceneManager.LoadScene("Level01");
    }
}
