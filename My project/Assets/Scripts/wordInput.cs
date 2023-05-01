using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wordInput : MonoBehaviour
{

    public wordManager wordManager;
    public static float charTyped = 0;
    private bool isPaused = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Time.timeScale = 1;
                isPaused = false;
            }
            else
            {
                Time.timeScale = 0;
                isPaused = true;
            }
                
        }
        foreach (char letter in Input.inputString)
        {
            
            wordManager.TypeLetter(letter);
            charTyped++;

        }
    }
}
