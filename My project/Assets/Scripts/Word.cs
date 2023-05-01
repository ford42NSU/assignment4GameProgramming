using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word
{
    public string word;
    private int typeIndex;

    public wordManager wordManager;
    wordDisplay display;

    public Word (string _word, wordDisplay _display)
    {
        word = _word;
        typeIndex = 0;

        display = _display;
        display.SetWord(word);
    }

    public char GetNextLetter ()
    {
        return word[typeIndex];
    }

    public void TypeLetter()
    {
        typeIndex++;
        display.RemoveLetter();
    }

    public bool WordTyped ()
    {
        bool WordTyped = (typeIndex >= word.Length);
        if (WordTyped)
        {
             display.RemoveWord();
        }
        return WordTyped;
    }

        
    
}
