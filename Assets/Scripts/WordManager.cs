using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{
    public List<Word> words;
    public WordSpawner wordSpawner;
    private bool hasActiveWord;
    private Word activeWord;
    public UIManager UiManager;
    public static bool IsGameOver = false;

    public void AddWord()
    {
        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        Debug.Log(word.word);
        words.Add(word);
    }

    void Update()
    {
        if (IsGameOver)
            enabled = false;
    }

    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            if (activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        }
        else
        {
            // check if the letter being typed match 
            // with the start letter of the words
            foreach (Word word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                    // using break statement
                    // so if, when there are many words with same start letter
                    // only the first one will get selected first
                }
            }
        }

        if (hasActiveWord && activeWord.WordTyped())
        {
            FindObjectOfType<AudioManager>().GetComponent<AudioManager>().PlayCompletedWordSfx();
            UiManager.IncreaseScore(1);
            hasActiveWord = false;
            words.Remove(activeWord);
        }
    }
}
