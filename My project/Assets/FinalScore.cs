using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using static wordManager;
using static wordSpawner;
using static wordInput;




public class FinalScore : MonoBehaviour
{
    public Text scores;
    private float percentage;
    // Start is called before the first frame update
    void Start()
    {
        percentage = charRight/charTyped;
        percentage *= 100;
        scores.text = "Words Spawned: " + wordsSpawned + "\nWords Completed: " + wordsRight + "\nCharacters Typed: " + charTyped + "\nCharacters Correct: " + charRight + "\nPercent Correct: " + percentage.ToString("0.00") + "%";
    }

}
