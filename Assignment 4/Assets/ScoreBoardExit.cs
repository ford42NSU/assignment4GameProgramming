using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using UnityEngine.IO;
using static Play;
using static Scores;

public class ScoreBoardExit : MonoBehaviour
{
    public Text nameList;
    public Text scoreList;
    public Text testList;


    public string filePath = "Scores.txt";
    public string[] strings;
    public string[] parts;
    public string newScore;
    // Start is called before the first frame update
    void Start()
    {
        newScore = CurrentScore.ToString() + "," + Names;
        testList.text = newScore;
        ReadStringsFromFile();
        insertNewScore();
        for (int i = 0; i < strings.Length; i++)
        {

            parts = strings[i].Split(',');
            scoreList.text += parts[0] + "\n\n";
            nameList.text += parts[1] + "\n\n";
            WriteToFile();
        }
    }

    void ReadStringsFromFile()
    {
        // Open the file for reading
        List<string> list = new List<string>();
        string line;
        StreamReader reader = new StreamReader(File.Open(filePath, FileMode.Open));

        // Iterate over the lines in the file
        while (reader.EndOfStream == false) {
            // Read the current line and add it to the string array
            line = reader.ReadLine();
            list.Add(line);
        }
        strings = list.ToArray();

        // Close the StreamReader
        reader.Close();
    }

    void insertNewScore()
    {
        int changepoint = 9;
        parts = strings[9].Split(',');
        if (GetFloatFromString(parts[0]) < CurrentScore)
        {
            for (int i = 8; i > 0; i--)
            {
                parts = strings[i].Split(',');
                if ( CurrentScore >= GetFloatFromString(parts[0]))
                {
                    changepoint = i;
                }
            }
            for (int i = 9; i > changepoint; i--)
            {
                strings[i] = strings[i-1];
            }
            strings[changepoint] = newScore;
        }
    }

    private void WriteToFile()
    {
        using (StreamWriter writer = File.CreateText(filePath))
        {
            foreach (string s in strings)
            {
                writer.WriteLine(s);
            }
        }
    }

    float GetFloatFromString(string input)
{
    if (String.IsNullOrEmpty(input))
    {
        return 9999f;
    }

    try
    {
        return float.Parse(input);
    }
    catch (FormatException)
    {
        // Catch FormatException if input can't be parsed to a float
        return 9999f;
    }
}
}


//