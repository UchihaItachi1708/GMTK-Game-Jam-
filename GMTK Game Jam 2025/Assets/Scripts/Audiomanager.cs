using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiomanager : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioSource WalkingAudio;

    [SerializeField] AudioClip Background;
    [SerializeField] AudioClip Walking;


    private void Start()
    {
        audioSource.clip = Background;
        WalkingAudio.loop = true;
        audioSource.Play();

        WalkingAudio.clip = Walking;
        WalkingAudio.loop = true;
        WalkingAudio.Play();
    }
}
