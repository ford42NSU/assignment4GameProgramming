using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wordManager : MonoBehaviour
{
    public List<Word> words;

    public wordSpawner wordSpawner;

    private bool hasActiveWord;
    private Word activeWord;

    public AudioSource click;

    public static int wordsRight = 0;
    public static float charRight = 0;
    public static int lives = 5;


    private void Start()
    {
        lives = 5;

    }
    

    public void AddWord()
    {
        
        Word word = new Word(wordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        

        words.Add(word);
    }

    public void TypeLetter (char letter)
    {
        if (hasActiveWord)
        {
            if (activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
                charRight++;
                click.Play();
            }
        }else
        {
            foreach(Word word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    charRight++;
                    click.Play();
                    break;
                }
            }
        }

        if (hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(activeWord);
            wordsRight++;
        }
    }

    public void failedWord()
    {

            hasActiveWord = false;
            words.RemoveAt(0);
        
        
    }


}
