using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgmAudioSource;
    public GameObject bumperSFXAudioSource;

    void Start()
    {
        playBGM();
    }

    private void playBGM()
    {
        bgmAudioSource.Play();
    }

    public void playSFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(bumperSFXAudioSource, spawnPosition, Quaternion.identity);
    }
}
