using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public static void playSound(AudioClip audioClip)
    {
        
        audioSource.clip = audioClip;
        audioSource.Play();
    }

}
