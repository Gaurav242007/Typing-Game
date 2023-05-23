using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WordDisplay : MonoBehaviour
{
    public TMP_Text text;
    public float fallSpeed = 1f;

    public void SetWord(string word)
    {
        text.text = word;
    }

    public void RemoveLetter()
    {
        // remove the first letter when call
        // remove the n-1 index means 0 - 1 => 0 index removed
        text.text = text.text.Remove(0, 1);
        text.color = Color.red;
    }

    public void RemoveWord()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
    }
}
