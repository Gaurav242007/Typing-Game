using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList = { "earth", "apple", "banana", "cat", "dog", "elephant", "flower", "guitar", "happiness", "island", "jungle", "kangaroo", "lion", "mountain", "night", "ocean", "piano", "queen", "rainbow", "sunset", "tree", "unicorn", "volcano", "waterfall", "xylophone", "yoga", "zebra", "airplane", "butterfly", "cheese", "dolphin", "eagle", "fire", "garden", "hammer", "ice cream", "jacket", "king", "lemon", "mango", "needle", "octopus", "penguin", "quilt", "rocket", "sunflower", "tiger", "umbrella", "violet", "whale", "xylophone", "yogurt", "zeppelin", "architect", "bicycle", "cactus", "dinosaur", "elephant", "fountain", "giraffe", "helicopter", "island", "jaguar", "koala", "lighthouse", "mushroom", "nightingale", "ostrich", "pineapple", "quokka", "raccoon", "snake", "toucan", "unicorn", "volcano", "watermelon", "xylophone", "yoga", "zebra", "apple", "banana", "cat", "dog", "elephant", "flower", "guitar", "happiness", "island", "jungle", "kangaroo", "lion" };

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}
