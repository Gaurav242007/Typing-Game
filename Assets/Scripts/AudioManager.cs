using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource LoseSfx;
    public AudioSource CompletedWordSfx;
    public AudioSource TypingSfx;

    public void PlayLoseSfx()
    {
        LoseSfx.Play();
    }

    public void PlayCompletedWordSfx()
    {
        CompletedWordSfx.Play();
    }

    public void PlayTypingSfx()
    {
        TypingSfx.Play();
    }
}
