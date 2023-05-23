using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadBar : MonoBehaviour
{
    public UIManager UiManager;
    public WordManager wordManager;
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Game Over");
        if (other.tag != "Word" && WordManager.IsGameOver == true)
            return;
        WordManager.IsGameOver = true;
        FindObjectOfType<AudioManager>().GetComponent<AudioManager>().PlayLoseSfx();
        UiManager.GameOver();
    }
}
