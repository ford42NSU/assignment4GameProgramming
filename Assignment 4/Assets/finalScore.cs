using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Scores;

public class finalScore : MonoBehaviour
{
  
    
    public Text scoresFinal;
    // Start is called before the first frame update
    void Start()
    {
        scoresFinal.text = CurrentScore.ToString();
    }

    
}
