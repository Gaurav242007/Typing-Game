using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AnimatedScore : MonoBehaviour
{
    public TMP_Text scoreText;

    // when the script start
    void OnEnable()
    {
        StartCoroutine(AnimateText());
    }

    IEnumerator AnimateText()
    {
        scoreText.text = "0";
        int score = 0;

        // wait for some seconds before the animation starts
        yield return new WaitForSeconds(.7f);

        while (score < UIManager.score)
        {
            score++;
            scoreText.text = score.ToString();
            // delay for few seconds
            yield return new WaitForSeconds(.05f);
        }
    }
}
