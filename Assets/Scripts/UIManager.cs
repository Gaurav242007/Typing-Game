using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public GameObject GameOverCanvas;
    public static int score = 0;

    void Start()
    {
        scoreText.text = "0";
        GameOverCanvas.SetActive(false);
    }

    public void IncreaseScore(int _score)
    {
        score += _score;
        scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        StartCoroutine(RestartGame());
    }

    IEnumerator RestartGame()
    {
        GameOverCanvas.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
