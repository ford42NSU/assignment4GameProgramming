using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{
    public static int CurrentScore = 0;  

    public Text scoreText;
    void Start ()
    {
        scoreText.text = CurrentScore.ToString();
    }
}
