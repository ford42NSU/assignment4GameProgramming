using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.IO;

public class wordGenerator : MonoBehaviour
{

    public string filePath = "Words.txt";
    private static string[] wordList;

    void Start()
    {
        List<string> list = new List<string>();
        string line;
        StreamReader reader = new StreamReader(File.Open(filePath, FileMode.Open));

        // Iterate over the lines in the file
        while (reader.EndOfStream == false) {
            // Read the current line and add it to the string array
            line = reader.ReadLine();
            list.Add(line);
        }
        wordList = list.ToArray();

        // Close the StreamReader
        reader.Close();
    }

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];
        return randomWord;
    }
}
