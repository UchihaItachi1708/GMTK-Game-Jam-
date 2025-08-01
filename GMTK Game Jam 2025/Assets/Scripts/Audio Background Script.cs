using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBackgroundScript : MonoBehaviour
{
    [SerializeField] private AudioSource Bg;
    [SerializeField] private AudioClip BgClip;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    private void Start()
    {
        Bg.clip = BgClip;
        Bg.loop = true;
        Bg.Play();
    }
}
