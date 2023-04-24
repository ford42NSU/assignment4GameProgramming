using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.IO;

public class Scoreboard : MonoBehaviour
{
    public Text nameList;
    public Text scoreList;


    public string filePath = "Scores.txt";
    public string[] strings;
    public string[] parts;
    // Start is called before the first frame update
    void Start()
    {
        ReadStringsFromFile();
        for (int i = 0; i < strings.Length; i++)
        {

            parts = strings[i].Split(',');
            scoreList.text += parts[0] + "\n\n";
            nameList.text += parts[1] + "\n\n";

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
}
